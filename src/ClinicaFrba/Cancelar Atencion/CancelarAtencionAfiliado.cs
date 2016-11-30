using ClinicaFrba.Abm_Afiliado;
using ClinicaFrba.Abm_Profesional;
using ClinicaFrba.BaseDeDatos;
using ClinicaFrba.BaseDeDatos.Componentes;
using ClinicaFrba.Registrar_Agenta_Medico;
using ClinicaFrba.Utils;
using ClinicaFrba.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelarAtencionAfiliado : Form
    {
        Afiliado afiliado;
        Profesional profesional;
        private DataSet pagingDS;
        private int scrollVal;
        private int cantTurnos;
        private int nroPagina;
        private int cantPaginas;
        private StringBuilder sql = new StringBuilder();
        private StringBuilder sqlCount = new StringBuilder();
        private StringBuilder sqlWhere = new StringBuilder("");
        private static readonly int CANT_POR_PAGINA = int.Parse(ConfigurationManager.AppSettings["valor.paginacion"]);

        public CancelarAtencionAfiliado()
        {
            InitializeComponent();
            this.afiliado = obtenerAfiliadoConUsername();
            this.pan_canAfiliado.Visible = true;
            this.btn_buscarAfiliado.Visible = false;
            this.txt_idAfiliado.Text = afiliado.getNroAfiliado();
        }

        public CancelarAtencionAfiliado(string administrador)
        {
            InitializeComponent();
            this.afiliado = obtenerAfiliadoConUsername();
            this.pan_canAfiliado.Visible = false;
            this.btn_buscarAfiliado.Visible = true;
        }

        private void CancelarAtencionAfiliado_Load(object sender, EventArgs e)
        {
            try
            {
                //Inicializamos todos los componentes
                //Seteamos como mínima fecha a buscar la seteada como actual en el sistema
                this.dtp_fecha_turno.MinDate = DateTime.Parse(Program.fechaActual);
                this.dtp_fecha_turno.Value = this.dtp_fecha_turno.MinDate;
                this.lbl_nro_pagina.Text = "";
                this.lbl_nro_turnos.Text = "";
                ManipulacionComponentes.deshabilitarComponentes(new List<Control>(){this.btn_primera,this.btn_anterior,this.btn_siguiente,this.btn_ultima,
                                                                              this.btn_aceptar});
                this.dtp_fecha_turno.Enabled = this.chk_buscar_fecha.Checked;
                //this.lbl_error_nro_doc.Visible = false;
                //this.lbl_error_nro_matricula.Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Se ha producido un error al cargar la pantalla: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void chk_buscar_fecha_CheckedChanged(object sender, EventArgs e)
        {
            this.dtp_fecha_turno.Enabled = this.chk_buscar_fecha.Checked;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.lbl_error_pro.Visible = false;
            this.lbl_error_esp.Visible = false;
            this.cmb_especialidades.Visible = false;
            this.lbl_especialidades.Visible = false;
            this.txt_profesional.Text = "";
            this.cmb_especialidades.SelectedIndex = -1;
            ManipulacionComponentes.vaciarGrid(this.dgv_turnos);
            this.lbl_nro_pagina.Text = "";
            this.lbl_nro_turnos.Text = "";
            this.chk_buscar_fecha.Checked = false;
            ManipulacionComponentes.deshabilitarComponentes(new List<Control>(){this.btn_primera,this.btn_anterior,this.btn_siguiente,this.btn_ultima,
                                                                              this.btn_aceptar});
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.lbl_error_pro.Visible = false;
            this.lbl_error_esp.Visible = false;

            if (validar_profesional())
            {
                try
                {

                    //Inicializamos los componentes antes de realizar la búsqueda
                    ManipulacionComponentes.vaciarGrid(this.dgv_turnos);
                    ManipulacionComponentes.deshabilitarComponentes(new List<Control>(){this.btn_primera,this.btn_anterior,this.btn_siguiente,this.btn_ultima,
                                                                              this.btn_aceptar});
                    this.lbl_nro_pagina.Text = "";
                    this.lbl_nro_turnos.Text = "";

                    ManipulacionComponentes.habilitarComponentes(new List<Control>(){this.btn_primera,this.btn_anterior,this.btn_siguiente,this.btn_ultima,
                                                                              this.btn_aceptar});
                    armarQuery();
                    pagingDS = new DataSet();
                    //Llenamos la grilla con el resultado de la búsqueda
                    ManipulacionComponentes.llenarGrid(this.dgv_turnos, sql.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Turnos");
                    this.dgv_turnos.DataSource = pagingDS;
                    this.dgv_turnos.DataMember = "Turnos";
                    //Obtenemos el total de turnos devuelto por la búsqueda 
                    cantTurnos = calcularFilasTotal();
                    lbl_nro_turnos.Text = cantTurnos.ToString();
                    //Si no hay turnos, hay una sóla página y no se puede seleccionar ninguno
                    if (cantTurnos == 0)
                    {
                        cantPaginas = 1;
                        ManipulacionComponentes.deshabilitarComponentes(new List<Control>(){this.btn_primera,this.btn_anterior,this.btn_siguiente,this.btn_ultima,
                                                                              this.btn_aceptar});
                    }
                    //Si hay turnos, obtenemos el total de páginas para mostrar
                    else
                    {
                        cantPaginas = cantTurnos / CANT_POR_PAGINA;
                    }
                    nroPagina = 1;
                    if (cantTurnos % CANT_POR_PAGINA > 0)
                    {
                        cantPaginas = cantPaginas + 1;
                    }
                    lbl_nro_pagina.Text = "Página " + nroPagina + " de " + cantPaginas;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("Se ha producido un error al buscar turnos: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private int calcularFilasTotal()
        {
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand(sqlCount.ToString(), cx);
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    sqlReader.Read();
                    return Int32.Parse(sqlReader["Cantidad Turnos"].ToString());

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw ex;
                }
            }
        }

        private void armarQuery()
        {
            sql.Clear();
            sqlCount.Clear();
            sql.Append(ConfigurationManager.AppSettings["query.obtener.turnos.select.grilla"]);
            sqlCount.Append(ConfigurationManager.AppSettings["query.obtener.turnos.count.grilla"]);
            //Armamos el where
            sqlWhere.Clear();
            sqlWhere.Append(" WHERE");
            sqlWhere.Append(ConfigurationManager.AppSettings["query.obtener.turnos.where.profesional.apellido"].Replace("{1}", this.profesional.Apellido));
            sqlWhere.Append(" AND").Append(ConfigurationManager.AppSettings["query.obtener.turnos.where.profesional.nombre"].Replace("{0}", this.profesional.Nombre));
            sqlWhere.Append(" AND").Append(ConfigurationManager.AppSettings["query.obtener.turnos.where.especialidad.descripcion"].Replace("{0}", this.cmb_especialidades.Text));
            sqlWhere.Append(" AND").Append(ConfigurationManager.AppSettings["query.obtener.turnos.where.afiliado"].Replace("{1}", this.afiliado.getDocumento()));
            sqlWhere.Append(" AND").Append(ConfigurationManager.AppSettings["query.obtener.turnos.where.not.cancelacion"]);
            if (this.dtp_fecha_turno.Enabled)
            {
                sqlWhere.Append(" AND").Append(ConfigurationManager.AppSettings["query.obtener.turnos.where.fecha"].Replace("{3}", "'" + this.dtp_fecha_turno.Value.ToString("yyyy/MM/dd") + "'"));
            }
            else
            {
                sqlWhere.Append(" AND").Append(ConfigurationManager.AppSettings["query.obtener.turnos.where.fecha.mayor"].Replace("{3}", "'" + Program.fechaActual + "'"));
            }


            sql.Append(sqlWhere);
            sqlCount.Append(sqlWhere);
            Console.WriteLine("Query: " + sql.ToString());
            Console.WriteLine("Query count: " + sqlCount.ToString());
        }

        private void btn_primera_Click(object sender, EventArgs e)
        {

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {

        }

        private void btn_ultima_Click(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.lbl_error_motivo.Visible = false;
            if (validar())
            {
                if (Mensajes.confirmaCambios())
                {
                    int turnoSeleccionado = int.Parse(this.dgv_turnos.SelectedRows[0].Cells["Nro Turno"].Value.ToString());
                    if (insertarCancelacion(this.txt_motivo.Text, 2, turnoSeleccionado, Program.fechaActual))
                    {
                        Mensajes.operacionExitosa();
                        this.Close();
                    }
                }
            }
        }

        private bool validar()
        {
            bool validacion = true;
            if (!ValidacionComponentes.textBoxLlenoCampo(this.txt_motivo))
            {
                this.lbl_error_motivo.Visible = true;
                validacion = false;
            }
            return validacion;
        }

        private bool validar_profesional()
        {
            bool validacion = true;
            if (!ValidacionComponentes.comboBoxSeleccionoOpcion(this.cmb_especialidades) && cmb_especialidades.Visible==true)
            {
                this.lbl_error_esp.Visible = true;
                validacion = false;
            }
            if (!ValidacionComponentes.textBoxLlenoCampo(this.txt_profesional))
            {
                this.lbl_error_pro.Visible = true;
                validacion = false;
            }
            return validacion;
        }

        private bool insertarCancelacion(String motivo, int idTipoCancelacion, int nroTurno, String fechaActual)
        {
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    cx.Open();
                    SqlCommand sqlCmd = new SqlCommand("PICO_Y_PALA.cancelarTurno", cx);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Add("@motivoCancelacion", SqlDbType.VarChar).Value = motivo;
                    sqlCmd.Parameters.Add("@tipoCancelacion", SqlDbType.Int).Value = idTipoCancelacion;
                    sqlCmd.Parameters.Add("@turno", SqlDbType.Decimal).Value = nroTurno;
                    sqlCmd.Parameters.Add("@fechaActual", SqlDbType.Date).Value = DateTime.Parse(fechaActual).Date;
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR AL PROCESAR LA CANCELACIÓN");
                    Console.WriteLine(ex.ToString());
                    //Al informar por pantalla el Message de la excepción, se muestra el error que arroja el StoreProcedure
                    MessageBox.Show(ex.Message, "Error al procesar la cancelación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private Afiliado obtenerAfiliadoConUsername()
        {
            StringBuilder query = new StringBuilder(ConfigurationManager.AppSettings["query.abm.afiliado.select"].ToString());
            query.Append(" AND usu.usu_username='" + Program.user + "'");
            Afiliado afiliado = new Afiliado();
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand(query.ToString(), cx);
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        afiliado.setApellido(sqlReader["Apellido"].ToString());
                        afiliado.setUsername(sqlReader["Usuario"].ToString());
                        afiliado.setNombre(sqlReader["Nombre"].ToString());
                        afiliado.setDocumento(sqlReader["Documento"].ToString());
                        afiliado.setNroAfiliado(sqlReader["Nro Afiliado"].ToString());
                        afiliado.setDireccion(sqlReader["Direccion"].ToString());
                        afiliado.setTelefono(sqlReader["Telefono"].ToString());
                        afiliado.setMail(sqlReader["Mail"].ToString());
                        afiliado.setFechaNac(sqlReader["Fecha de Nacimiento"].ToString());
                        afiliado.setEstadoCivil(sqlReader["Estado Civil"].ToString());
                        afiliado.setPlan(sqlReader["Plan"].ToString());
                        afiliado.setNroConsultas(sqlReader["Nro Consulta"].ToString());
                        afiliado.setHabilitado(sqlReader["Activo"].ToString().Equals("SI") ? true : false);
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw ex;
                }

                return afiliado;
            }
        }

        private void btn_buscarAfiliado_Click(object sender, EventArgs e)
        {
            using (BuscarAfiliado buscarAfi = new BuscarAfiliado("Seleccionar"))
            {
                if (buscarAfi.ShowDialog().Equals(DialogResult.OK))
                {
                    this.afiliado = buscarAfi.AfiliadoReturn;
                    if (this.afiliado.getHabilitado())
                    {
                        this.txt_idAfiliado.Text = this.afiliado.getNroAfiliado();
                        this.pan_canAfiliado.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("El afiliado seleccionado no se encuentra habilitado para realizar esta operacion", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                }

            }
        }

        private void btn_buscar_profesional_Click(object sender, EventArgs e)
        {
            using (BuscarProfesionales buscarProfesional = new BuscarProfesionales())
            {
                if (buscarProfesional.ShowDialog().Equals(DialogResult.OK))
                {
                    this.profesional = buscarProfesional.ProfesionalReturn;
                    this.txt_profesional.Text = this.profesional.Apellido + ", " + this.profesional.Nombre;
                    StringBuilder sqlEspecialidadesProfesional = new StringBuilder(ConfigurationManager.AppSettings["query.obtener.especialidades.profesional.select"]);
                    sqlEspecialidadesProfesional.Append(" WHERE");
                    sqlEspecialidadesProfesional.Append(ConfigurationManager.AppSettings["query.obtener.profesionales.where.nro.doc"].Replace("{2}", this.profesional.NroDoc.ToString()));
                    this.cmb_especialidades.Items.Clear();
                    ManipulacionComponentes.llenarComboBox(this.cmb_especialidades, sqlEspecialidadesProfesional.ToString(), "Especialidad");
                    this.cmb_especialidades.DropDownWidth = ManipulacionComponentes.obtenerDropDownMaxWidthCombo(this.cmb_especialidades);
                    this.cmb_especialidades.Visible = true;
                    this.lbl_especialidades.Visible = true;
                }
            }

        }
    }
}
