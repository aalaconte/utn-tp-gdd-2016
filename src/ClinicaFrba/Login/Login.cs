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

namespace ClinicaFrba.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            SqlConnection cx = null;
            try
            {
                if (string.IsNullOrWhiteSpace(this.txt_usuario.Text))
                {
                    MessageBox.Show("Complete el campo usuario", "Error en el login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txt_usuario.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(this.txt_password.Text))
                {
                    MessageBox.Show("Complete el campo contraseña", "Error en el login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txt_password.Focus();
                    return;
                }

                cx = Connection.getConnection();
                cx.Open();
                SqlCommand sqlCmd = new SqlCommand("PICO_Y_PALA.checkLoginAndUpdateFailures", cx);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@user", SqlDbType.VarChar).Value = this.txt_usuario.Text;
                sqlCmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = Seguridad.Security.encrypt(this.txt_password.Text);
                sqlCmd.Parameters.Add("@ok", SqlDbType.Bit).Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add("@enabled", SqlDbType.Bit).Direction = ParameterDirection.Output;
                sqlCmd.ExecuteNonQuery();
                if ((bool)sqlCmd.Parameters["@ok"].Value)
                {
                    MessageBox.Show("Bienvenido, " + this.txt_usuario.Text + "!", "Login exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Program.user = sqlCmd.Parameters["@user"].Value.ToString();
                    int cantRoles = Usuario.Usuario.obtenerCantidadDeRoles(Program.user);
                    this.txt_password.Text = "";
                    this.txt_usuario.Text = "";
                    this.txt_usuario.Focus();
                    switch (cantRoles)
                    {
                        case 0:
                            MessageBox.Show("Su usuario no tiene asignado ningún rol habilitado!\nConsulte con el administrador", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Program.limpiarVariablesEntorno();
                            this.Show();
                            break;
                        case 1:
                            Program.rol = Usuario.Usuario.obtenerPrimerRol(Program.user);
                            Main.MainPage m1 = new Main.MainPage(this);
                            m1.Show();
                            break;
                        default:
                            new AbmRol.SeleccionRol(this).Show();
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Enabled?: " + sqlCmd.Parameters["@enabled"].Value);
                    if ((bool)sqlCmd.Parameters["@enabled"].Value)
                    {
                        MessageBox.Show("Usuario o Contraseña inválidos", "Error en el login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txt_usuario.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("El usuario ha sido inhabilitado por exceso de intentos fallidos. Contacte al administrador", "Error en el login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txt_usuario.Focus();
                        return;
                    }
                }
                sqlCmd.Dispose();
                cx.Close();
            }
            catch (Exception exception)
            {
                cx.Close();
                MessageBox.Show(exception.Message);
                return;
            }
        }
    }
}
