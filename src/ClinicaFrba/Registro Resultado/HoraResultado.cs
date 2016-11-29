using ClinicaFrba.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Resultado
{
    public partial class HoraResultado : Form
    {
        string consultaID;
        DateTime horaTurno;
        DateTime maxHoraResultado;
        public DateTime horaReturn{get; set;}
        public bool atendio { get; set; }
        public HoraResultado(String idConsulta)
        {
            InitializeComponent();
            this.consultaID = idConsulta;
            this.horaTurno = calcularHoraTurno();
            this.maxHoraResultado = this.horaTurno.AddMinutes(30);
            this.dtp_HoraResultado.Value = this.horaTurno;

        }

        private void chb_ocurrioAtencion_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_ocurrioAtencion.Checked)
            {
                this.lbl_horaResultado.Visible = true;
                this.dtp_HoraResultado.Visible = true;
            }
            else
            {
                this.lbl_horaResultado.Visible = false;
                this.dtp_HoraResultado.Visible = false;
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (this.chb_ocurrioAtencion.Checked)
            {
                if (this.dtp_HoraResultado.Value >= this.horaTurno && this.dtp_HoraResultado.Value <= this.maxHoraResultado)
                {
                    this.atendio = true;
                    this.horaReturn = this.dtp_HoraResultado.Value;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La hora del resutado debe estar dentro del rango de atencion del turno", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                this.atendio = false;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private DateTime calcularHoraTurno()
        {
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    String unaQuery = "select tur.tur_fecha_hora HoraTurno from pico_y_pala.consulta con join pico_y_pala.turno tur on con.con_tur_id=tur.tur_id where con.con_id=" + consultaID;
                    SqlCommand sqlCmd = new SqlCommand(unaQuery, cx);
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    sqlReader.Read();
                    return DateTime.Parse(sqlReader["HoraTurno"].ToString());

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw ex;
                }
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
