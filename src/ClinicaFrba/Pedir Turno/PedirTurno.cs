using ClinicaFrba.Abm_Afiliado;
using ClinicaFrba.Abm_Especialidades_Medicas;
using ClinicaFrba.Abm_Profesional;
using ClinicaFrba.BaseDeDatos;
using ClinicaFrba.BaseDeDatos.Componentes;
using ClinicaFrba.Registrar_Agenta_Medico;
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

namespace ClinicaFrba.Pedir_Turno
{
    public partial class PedirTurno : Form
    {
        private Afiliado afiliado;
        private Profesional profesional;
        private List<Especialidad> especialidades = new List<Especialidad>();
        private List<AgendaProfesional> agendas = new List<AgendaProfesional>();

        public PedirTurno()
        {
            InitializeComponent();
            this.afiliado = obtenerAfiliadoConUsername();
            Console.WriteLine("Afiliado: " + this.afiliado.getUsername() + " - " + this.afiliado.getApellido() + ", " + this.afiliado.getNombre());
        }

        private void btn_buscar_profesional_Click(object sender, EventArgs e)
        {
            using (BuscarProfesionales buscarProfesional = new BuscarProfesionales())
            {
                if (buscarProfesional.ShowDialog().Equals(DialogResult.OK))
                {
                    try
                    {
                        //inicializarCampos();
                        this.profesional = buscarProfesional.ProfesionalReturn;
                        this.txt_profesional.Text = this.profesional.Apellido + ", " + this.profesional.Nombre;
                        int anchoTextoPx = TextRenderer.MeasureText(this.txt_profesional.Text, this.txt_profesional.Font).Width;
                        if (anchoTextoPx > this.txt_profesional.Width)
                        {
                            this.txt_profesional.Width = anchoTextoPx;
                        }
                        StringBuilder sqlEspecialidadesProfesional = new StringBuilder(ConfigurationManager.AppSettings["query.obtener.especialidades.profesional.select"]);
                        sqlEspecialidadesProfesional.Append(" WHERE");
                        sqlEspecialidadesProfesional.Append(ConfigurationManager.AppSettings["query.obtener.profesionales.where.nro.doc"].Replace("{2}", this.profesional.NroDoc.ToString()));
                        this.cmb_especialidad.Items.Clear();
                        ManipulacionComponentes.llenarComboBox(this.cmb_especialidad, sqlEspecialidadesProfesional.ToString(), "Especialidad");
                        this.cmb_especialidad.DropDownWidth = ManipulacionComponentes.obtenerDropDownMaxWidthCombo(this.cmb_especialidad);
                        this.especialidades = obtenerEspecialidadesProfesional(this.profesional.NroDoc, sqlEspecialidadesProfesional.ToString());

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        MessageBox.Show("Se produjo un error al consultar las especialidades del profesional: " + this.txt_profesional.Text, "Error en el login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private List<Especialidad> obtenerEspecialidadesProfesional(int nroDoc, String query)
        {
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand(query, cx);
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    List<Especialidad> especialidadesLocal = new List<Especialidad>();

                    while (sqlReader.Read())
                    {
                        especialidadesLocal.Add(new Especialidad(int.Parse(sqlReader["ID"].ToString()), sqlReader["Especialidad"].ToString()));
                    }

                    return especialidadesLocal;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void cmb_especialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<AgendaProfesional> agendasConFechaDesdeMayoresAActual = new List<AgendaProfesional>();
            this.agendas = obtenerAgendasProfesionalEspecialidad();
            agendasConFechaDesdeMayoresAActual = this.agendas.Where(agenda => agenda.FechaDesde > DateTime.Parse(Program.fechaActual).Date).ToList();
            DateTime fechaMax = this.agendas.Max(agenda => agenda.FechaHasta).Date;
            DateTime fechaMin = agendasConFechaDesdeMayoresAActual.Min(agenda => agenda.FechaDesde).Date;
            Console.WriteLine("fechaMin: " + fechaMin.ToString());
            Console.WriteLine("fechaActualSistema: " + DateTime.Parse(Program.fechaActual).Date.ToString());
            this.dtp_fecha_turno.Enabled = fechaMax >= DateTime.Parse(Program.fechaActual).Date;
            if (fechaMax >= DateTime.Parse(Program.fechaActual).Date)
            {
                this.lbl_error_sin_agenda.Visible = false;
                this.dtp_fecha_turno.MinDate = (fechaMin > DateTime.Parse(Program.fechaActual).Date) ? fechaMin : DateTime.Parse(Program.fechaActual).Date;
                this.dtp_fecha_turno.MaxDate = fechaMax;
            }
            else
            {
                this.lbl_error_sin_agenda.Visible = true;
            }

        }

        private List<AgendaProfesional> obtenerAgendasProfesionalEspecialidad()
        {
            List<AgendaProfesional> agendasReturn = new List<AgendaProfesional>();
            using (SqlConnection cx = Connection.getConnection())
            {
                Especialidad especialidadSeleccionada = this.especialidades.Find(especialidad => especialidad.Descripcion.Equals(this.cmb_especialidad.SelectedItem.ToString()));
                StringBuilder query = new StringBuilder(ConfigurationManager.AppSettings["query.obtener.agendas.select"].ToString());
                query.Append(ConfigurationManager.AppSettings["query.obtener.agendas.group.by"].ToString());
                query.Append(" HAVING");
                query.Append(ConfigurationManager.AppSettings["query.obtener.agendas.having.profesional"].Replace("{0}", this.profesional.NroDoc.ToString()).ToString());
                query.Append(" AND");
                query.Append(ConfigurationManager.AppSettings["query.obtener.agendas.having.especialidad"].Replace("{8}", especialidadSeleccionada.Id.ToString()));
                SqlCommand sqlCmd = new SqlCommand(query.ToString(), cx);
                sqlCmd.CommandType = CommandType.Text;
                try
                {
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        AgendaProfesional agenda = new AgendaProfesional();
                        agenda.Dia = new Dia((int)sqlReader["dia_id"],sqlReader["dia"].ToString());
                        agenda.Especialidad = especialidadSeleccionada;
                        agenda.FechaDesde = DateTime.Parse(sqlReader["fechaDesde"].ToString()).Date;
                        agenda.FechaHasta = DateTime.Parse(sqlReader["fechaHasta"].ToString()).Date;
                        agenda.hhDesde = TimeSpan.Parse(sqlReader["desde"].ToString());
                        agenda.hhHasta = TimeSpan.Parse(sqlReader["hasta"].ToString());
                        agendasReturn.Add(agenda);
                    }
                    sqlReader.Close();
                    sqlReader.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Se ha producido un error al buscar las agendas para el profesional y la especialidad seleccionados");
                    Console.WriteLine(ex);
                    MessageBox.Show("Se ha producido un error al buscar las agendas para el profesional y la especialidad seleccionados", "Error al buscar especialidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return agendasReturn;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dtp_fecha_turno_ValueChanged(object sender, EventArgs e)
        {
            this.cmb_hora_turno.Enabled = this.dtp_fecha_turno.Enabled;
            //this.cmb_hora_has
            //foreach (String horario : agendas.

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
    }
}
