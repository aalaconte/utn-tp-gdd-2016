using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelarAdmin : Form
    {
        public CancelarAdmin()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelarAdmin_Load(object sender, EventArgs e)
        {
            this.cb_TipoCan.Items.Add("Afiliado");
            this.cb_TipoCan.Items.Add("Profesional");
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (!(this.cb_TipoCan.SelectedIndex == -1))
            {
                if (this.cb_TipoCan.SelectedIndex == 0)
                {
                    CancelarAtencionAfiliado cancelarAtencion = new CancelarAtencionAfiliado(Program.user);
                    cancelarAtencion.ShowDialog();
                }
                else
                {
                    CancelarAtencionProfesional cancelarAtencion = new CancelarAtencionProfesional(Program.user);
                    cancelarAtencion.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciones el tipo de Cancelacion que desea realizar.", "Error al seleccionar Tipo de Cancelacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
