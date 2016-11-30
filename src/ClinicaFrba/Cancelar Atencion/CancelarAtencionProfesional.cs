using ClinicaFrba.Abm_Profesional;
using ClinicaFrba.BaseDeDatos;
using ClinicaFrba.Registrar_Agenta_Medico;
using ClinicaFrba.Utils;
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
    public partial class CancelarAtencionProfesional : Form
    {
        private Profesional profesional;
        public CancelarAtencionProfesional()
        {
            InitializeComponent();
            profesional=obtenerProfesionalPorUsername();
            this.txt_profesional.Text = this.profesional.Apellido + ", " + this.profesional.Nombre;
            this.pan_CancelarPro.Visible = true;
            this.btn_buscar_profesional.Visible = true;
        }

        public CancelarAtencionProfesional(string administrador)
        {
            InitializeComponent();
            this.pan_CancelarPro.Visible = false;
            this.btn_buscar_profesional.Visible = true;
        }

        private void CancelarAtencionProfesional_Load(object sender, EventArgs e)
        {
            //Seteamos como mínima fecha a buscar la seteada como actual en el sistema
            this.dtp_fecha_desde.MinDate = DateTime.Parse(Program.fechaActual);
            this.dtp_fecha_desde.Value = this.dtp_fecha_desde.MinDate;
            this.dtp_fecha_hasta.Value = this.dtp_fecha_desde.Value.AddDays(1);
        }

        private void chk_rango_fechas_CheckedChanged(object sender, EventArgs e)
        {
            this.dtp_fecha_hasta.Enabled = this.chk_rango_fechas.Checked;
        }

        private void dtp_fecha_desde_ValueChanged(object sender, EventArgs e)
        {
            this.dtp_fecha_hasta.MinDate = this.dtp_fecha_desde.Value.AddDays(1);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (Mensajes.confirmaCambios())
                {
                    using (SqlConnection cx = Connection.getConnection())
                    {
                        try
                        {
                            cx.Open();
                            SqlCommand sqlCmd = new SqlCommand();
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Connection = cx;
                            if (this.chk_rango_fechas.Checked)
                            {
                                sqlCmd.CommandText = "PICO_Y_PALA.cancelarTurnosRangoFechas";
                                sqlCmd.Parameters.Add("@nroDocProf", SqlDbType.Decimal).Value = this.profesional.NroDoc;
                                sqlCmd.Parameters.Add("@motivoCancelacion", SqlDbType.VarChar).Value = this.txt_motivo_cancelacion.Text;
                                sqlCmd.Parameters.Add("@tipoCancelacion", SqlDbType.Int).Value = 1;
                                sqlCmd.Parameters.Add("@fechaDesde", SqlDbType.Date).Value = this.dtp_fecha_desde.Value.Date;
                                sqlCmd.Parameters.Add("@fechaHasta", SqlDbType.Date).Value = this.dtp_fecha_hasta.Value.Date;
                                sqlCmd.Parameters.Add("@fechaActual", SqlDbType.Date).Value = DateTime.Parse(Program.fechaActual).Date;
                            }
                            else
                            {
                                sqlCmd.CommandText = "PICO_Y_PALA.cancelarTurnosFecha";
                                sqlCmd.Parameters.Add("@nroDocProf", SqlDbType.Decimal).Value = this.profesional.NroDoc;
                                sqlCmd.Parameters.Add("@motivoCancelacion", SqlDbType.VarChar).Value = this.txt_motivo_cancelacion.Text;
                                sqlCmd.Parameters.Add("@tipoCancelacion", SqlDbType.Int).Value = 1;
                                sqlCmd.Parameters.Add("@fechaCancela", SqlDbType.Date).Value = this.dtp_fecha_desde.Value;
                                sqlCmd.Parameters.Add("@fechaActual", SqlDbType.Date).Value = DateTime.Parse(Program.fechaActual).Date;
                            }
                            sqlCmd.ExecuteNonQuery();
                            sqlCmd.Dispose();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("ERROR AL LLAMAR A cancelarTurnosFecha");
                            Console.WriteLine(ex);
                            MessageBox.Show("Se produjo un error al cancelar los turnos en el rango solicitado: " +
                                this.dtp_fecha_desde.Value.ToString() + " a " + this.dtp_fecha_hasta.Value.ToString() + ". " +
                                ex.Message, "Error al registrar el turno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    Mensajes.operacionExitosa();
                    this.Close();
                }
            }
        }

        private bool validar()
        {
            this.lbl_error_motivo.Visible = !Validaciones.ValidacionComponentes.textBoxLlenoCampo(this.txt_motivo_cancelacion);
            return !this.lbl_error_motivo.Visible;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private Profesional obtenerProfesionalPorUsername()
        {
            StringBuilder query = new StringBuilder(ConfigurationManager.AppSettings["query.obtener.profesionales.select"].ToString());
            query.Append(" AND u.usu_username='" + Program.user + "'");
            Profesional pro = new Profesional();
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand(query.ToString(), cx);
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        pro.Apellido=(sqlReader["Apellido"].ToString());
                        pro.Nombre=(sqlReader["Nombre"].ToString());
                        pro.NroDoc = Int32.Parse(sqlReader["Nro Documento"].ToString());
                        pro.Matricula = Int32.Parse(sqlReader["Matrícula"].ToString());

                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw ex;
                }

                return pro;
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
                    this.pan_CancelarPro.Visible = true;
                }
            }
        }

    }
}
