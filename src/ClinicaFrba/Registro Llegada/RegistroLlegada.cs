using ClinicaFrba.Abm_Afiliado;
using ClinicaFrba.Abm_Profesional;
using ClinicaFrba.BaseDeDatos;
using ClinicaFrba.BaseDeDatos.Componentes;
using ClinicaFrba.Registrar_Agenta_Medico;
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

namespace ClinicaFrba.Registro_Llegada
{
    public partial class RegistroLlegada : Form
    {
        private StringBuilder sqlEspecialidadesProfesional = new StringBuilder();
        private StringBuilder sqlCount = new StringBuilder();
        private StringBuilder sqlAnd = new StringBuilder();
        private Profesional profesional;
        private Afiliado afiliado;
        private DataSet pagingDS;
        private int scrollVal;
        private int cantTurnos;
        private int nroPagina;
        private int cantPaginas;
        private static readonly int CANT_POR_PAGINA = int.Parse(ConfigurationManager.AppSettings["valor.paginacion"]);

        public RegistroLlegada()
        {
            InitializeComponent();
            this.dtp_fechaTurno.Value = DateTime.Parse(ConfigurationManager.AppSettings["fechaActualSistema"].ToString());
        }
        private void btn_buscar_profesional_Click(object sender, EventArgs e)
        {
            using (BuscarProfesionales buscarProfesional = new BuscarProfesionales())
            {
                if (buscarProfesional.ShowDialog().Equals(DialogResult.OK))
                {
                        this.profesional = buscarProfesional.ProfesionalReturn;
                        this.txt_profesional.Text = this.profesional.Apellido + ", " + this.profesional.Nombre;
                }
            }

        }

        private void btn_buscarTurnos_Click(object sender, EventArgs e)
        {
                try
                {
                    this.lbl_warn_afiliado.Visible = false;
                    if (validar())
                    {

                        ManipulacionComponentes.habilitarComponentes(new List<Control>(){this.btn_primera,this.btn_anterior,this.btn_siguiente,this.btn_ultima,
                                                                              this.btn_seleccionar});
                        this.lblCantTurnos.Text = "Cantidad de Turnos";
                        scrollVal = 0;
                        pagingDS = new DataSet();
                        armarQuery();
                        ManipulacionComponentes.llenarGrid(dgv_turnosProfesional, sqlEspecialidadesProfesional.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Turnos");
                        dgv_turnosProfesional.DataSource = pagingDS;
                        dgv_turnosProfesional.DataMember = "Turnos";
                        cantTurnos = calcularFilasTotal();
                        lbl_nroTurno.Text = cantTurnos.ToString();
                        cantPaginas = cantTurnos / CANT_POR_PAGINA;
                        nroPagina = 1;
                        if (cantTurnos % CANT_POR_PAGINA > 0)
                        {
                            cantPaginas = cantPaginas + 1;
                        }
                        if (this.cantPaginas == 0)
                        { this.cantPaginas++; }

                        lbl_nro_pagina.Text = "Página " + nroPagina + " de " + cantPaginas;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("Se ha producido un error al buscar turnos: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            
        }

        private void armarQuery()
        {

            this.sqlEspecialidadesProfesional.Clear();
            this.sqlCount.Clear();
            sqlEspecialidadesProfesional.Append(ConfigurationManager.AppSettings["query.obtener.turnos.select.not.consultas"].Replace("{2}", this.dtp_fechaTurno.Value.Year.ToString()).Replace("{3}", this.dtp_fechaTurno.Value.Month.ToString()).Replace("{4}", this.dtp_fechaTurno.Value.Day.ToString()));
            sqlCount.Append(ConfigurationManager.AppSettings["query.obtener.turnos.count.not.consultas"].Replace("{2}", this.dtp_fechaTurno.Value.Year.ToString()).Replace("{3}", this.dtp_fechaTurno.Value.Month.ToString()).Replace("{4}", this.dtp_fechaTurno.Value.Day.ToString()));
            //Armamos los AND
            sqlAnd.Clear();
            if (ValidacionComponentes.textBoxLlenoCampo(this.txt_profesional))
            {
                sqlAnd.Append(ConfigurationManager.AppSettings["query.obtener.turnos.profesionales.and"].Replace("{1}", this.profesional.NroDoc.ToString()));
            }
            if (ValidacionComponentes.textBoxLlenoCampo(this.txt_idAfiliado))
            {
                sqlAnd.Append(ConfigurationManager.AppSettings["query.obtener.turnos.afiliado.and"].Replace("{5}", this.txt_idAfiliado.Text));
            }
            sqlEspecialidadesProfesional.Append(sqlAnd);
            sqlCount.Append(sqlAnd);
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
                    return Int32.Parse(sqlReader["total_turnos"].ToString());

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw ex;
                }
            }
        }

        private void RegistroLlegada_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_primera_Click(object sender, EventArgs e)
        {
            try
            {
                scrollVal = 0;
                nroPagina = 1;
                ManipulacionComponentes.llenarGrid(dgv_turnosProfesional, sqlEspecialidadesProfesional.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Turnos");
                lbl_nro_pagina.Text = "Página " + nroPagina + " de " + cantPaginas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Error al procesar la solicitud: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                scrollVal = scrollVal - CANT_POR_PAGINA;
                if (scrollVal <= 0)
                {
                    scrollVal = 0;
                    nroPagina = 1;
                }
                else
                {
                    --nroPagina;
                }
                ManipulacionComponentes.llenarGrid(dgv_turnosProfesional, sqlEspecialidadesProfesional.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Turnos");
                lbl_nro_pagina.Text = "Página " + nroPagina + " de " + cantPaginas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Error al procesar la solicitud: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                scrollVal = scrollVal + CANT_POR_PAGINA;
                if (scrollVal >= cantTurnos)
                {
                    scrollVal = scrollVal - CANT_POR_PAGINA;
                }
                else
                {
                    lbl_nro_pagina.Text = "Página " + ++nroPagina + " de " + cantPaginas;
                }
                ManipulacionComponentes.llenarGrid(dgv_turnosProfesional, sqlEspecialidadesProfesional.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Turnos");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Error al procesar la solicitud: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_ultima_Click(object sender, EventArgs e)
        {
            try
            {
                scrollVal = cantTurnos / CANT_POR_PAGINA;
                if (cantTurnos % CANT_POR_PAGINA > 0)
                {
                    /*Para que muestre realmente los registros que entrarían en la última página como si hiciésemos "Siguiente"
                     * hasta el final
                     */
                    scrollVal = cantTurnos - (cantTurnos % CANT_POR_PAGINA);

                }
                else
                {
                    scrollVal = cantTurnos - CANT_POR_PAGINA;
                }
                ManipulacionComponentes.llenarGrid(dgv_turnosProfesional, sqlEspecialidadesProfesional.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Turnos");
                nroPagina = cantPaginas;
                lbl_nro_pagina.Text = "Página " + nroPagina + " de " + cantPaginas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Error al procesar la solicitud: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_buscarAfiliado_Click(object sender, EventArgs e)
        {
            using (BuscarAfiliado buscarAfi = new BuscarAfiliado("Seleccionar"))
            {
                if (buscarAfi.ShowDialog().Equals(DialogResult.OK))
                {
                        this.afiliado = buscarAfi.AfiliadoReturn;
                    if(this.afiliado.getHabilitado())
                        this.txt_idAfiliado.Text = this.afiliado.getNroAfiliado();
                    else
                        MessageBox.Show("El afiliado seleccionado no se encuentra habilitado para realizar esta operacion", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
             if (this.dgv_turnosProfesional.DisplayedRowCount(true) == 0)
            {
                MessageBox.Show("Seleccione un afiliado de la lista", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Turno turno = new Turno(this.dgv_turnosProfesional.SelectedRows[0].Cells[0].Value.ToString(), this.dgv_turnosProfesional.SelectedRows[0].Cells[4].Value.ToString());
            this.Close();
            SeleccionarBono selecBono = new Registro_Llegada.SeleccionarBono(afiliado, turno);
            selecBono.ShowDialog();
             }
        }

        private bool validar()
        {
            bool validacion = true;
            if (!ValidacionComponentes.textBoxLlenoCampo(this.txt_idAfiliado))
            {
                this.lbl_warn_afiliado.Visible = true;
                validacion = false;
            }

            return validacion;
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
