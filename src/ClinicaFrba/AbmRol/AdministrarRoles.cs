using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.AbmRol
{
    public partial class AdministrarRoles : Form
    {
        public AdministrarRoles()
        {
            InitializeComponent();
        }

        private void AdministrarRoles_Load(object sender, EventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            BuscarRol buscarModificar = new BuscarRol("Modificar");
            buscarModificar.ShowDialog();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            AbmRol crear = new AbmRol();
            crear.ShowDialog();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            BuscarRol buscarEliminar = new BuscarRol("Eliminar");
            buscarEliminar.ShowDialog();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
