using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class HoraLlegada : Form
    {
        String fechaTurno;
        public DateTime fechaReturn { get; set; }

        public HoraLlegada(String fecha)
        {
            InitializeComponent();
            this.fechaTurno = fecha;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (llegoAntesTurno(DateTime.Parse(this.fechaTurno), this.dtp_HoraLlegada.Value))
            {
                this.fechaReturn = this.dtp_HoraLlegada.Value;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("La hora de llegada debe ser igual o anterior a la del turno solicitado.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool llegoAntesTurno(DateTime fechaTurno, DateTime fechaLlegada)
        {
            bool resultado = true;
            String parteDiaTurno= fechaTurno.ToString("tt", CultureInfo.InvariantCulture);
            String parteDiaLlegada = fechaLlegada.ToString("tt", CultureInfo.InvariantCulture);
            if (parteDiaTurno.Equals(parteDiaLlegada) || (parteDiaTurno.Equals("PM") && parteDiaLlegada.Equals("AM")))
            {
                if (fechaTurno.Hour < fechaLlegada.Hour)
                {
                    resultado = false;
                }
                if (fechaTurno.Hour == fechaLlegada.Hour && fechaTurno.Minute < fechaLlegada.Minute)
                {
                    resultado = false;
                }
                if (fechaTurno.Hour == fechaLlegada.Hour && fechaTurno.Minute == fechaLlegada.Minute && fechaTurno.Second < fechaLlegada.Second)
                {
                    resultado = false;
                }
            }
            else
                resultado = false;

            return resultado;
        }

    }
}
