using ClinicaFrba.BaseDeDatos.Componentes;
using ClinicaFrba.Validaciones;
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
    public partial class SeleccionRol : Form
    {
        private Login.Login login;

        public SeleccionRol()
        {
            InitializeComponent();
        }

        public SeleccionRol(Login.Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void SeleccionRol_Load(object sender, EventArgs e)
        {
            try
            {
                StringBuilder query = new StringBuilder();
                query.Append("select rol_id,rol_nombre from pico_y_pala.usuario us, pico_y_pala.rol_usuario rus, pico_y_pala.rol rol");
                query.Append(" where usu_username='").Append(Program.user).Append("'");
                query.Append(" and usu_username = rus_usuario and rus_rol = rol_id");
                query.Append(" and rol_habilitado=1");
                ManipulacionComponentes.llenarComboBox(this.cmb_rol, query.ToString(), "rol_nombre");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Se ha producido un error al obtener los roles", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (ValidacionComponentes.comboBoxSeleccionoOpcion(this.cmb_rol))
            {
                Program.rol = this.cmb_rol.SelectedItem.ToString();
                this.Hide();
                new Main.MainPage(this.login).Show();
            }
            else
            {
                MessageBox.Show("Seleccione un rol del menú desplegable");
                return;
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
