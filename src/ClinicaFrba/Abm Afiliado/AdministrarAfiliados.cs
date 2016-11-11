using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class AdministrarAfiliados : Form
    {
        public AdministrarAfiliados()
        {
            InitializeComponent();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            AltaAfiliado altaAfi = new Abm_Afiliado.AltaAfiliado();
            altaAfi.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            BuscarAfiliado modifAfi = new Abm_Afiliado.BuscarAfiliado("Seleccionar");
            modifAfi.ShowDialog();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            BuscarAfiliado bajaAfi = new Abm_Afiliado.BuscarAfiliado("Dar de Baja");
            bajaAfi.ShowDialog();
        }

    }
}
