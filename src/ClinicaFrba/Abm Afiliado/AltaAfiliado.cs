using ClinicaFrba.BaseDeDatos;
using ClinicaFrba.BaseDeDatos.Componentes;
using ClinicaFrba.Utils;
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

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class AltaAfiliado : Form
    {
        private int codigoAfiliado;

        public AltaAfiliado()
        {
            InitializeComponent();
            this.codigoAfiliado = 1;
        }

        public AltaAfiliado(String idAfiliadoTitular, int codigoAfi)
        {
            InitializeComponent();
            this.cbFamACargo.Checked = false;
            this.cbFamACargo.Enabled = false;
            this.chbGrupoFamiliar.Checked = true;
            this.chbGrupoFamiliar.Enabled = false;
            this.gbGrupoFamiliar.Enabled = false;
            this.codigoAfiliado = codigoAfi;
            this.txtDocAfiTitular.Text = idAfiliadoTitular;
        }

        private void AltaAfiliado_Load(object sender, EventArgs e)
        {
            try
            {
                ManipulacionComponentes.llenarComboBox(this.cbPlan, "select pla_desc from PICO_Y_PALA.planes", "pla_desc");
                this.cbSexo.Items.Add("M");
                this.cbSexo.Items.Add("F");
                ManipulacionComponentes.llenarComboBox(this.cbEstadoCivil, "select eci_desc from PICO_Y_PALA.estado_civil", "eci_desc");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Al obtener los planes y estados civiles", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void chbGrupoFamiliar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbGrupoFamiliar.Checked == true)
            {
                this.gbGrupoFamiliar.Visible = true;
                this.cbFamACargo.Checked = false;
                this.cbFamACargo.Enabled = false;
            }
            else
            {
                this.gbGrupoFamiliar.Visible = false;
                this.cbFamACargo.Enabled = true;
            }
        }

        private void cbFamACargo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbFamACargo.Checked == true)
                this.nudFamACargo.Visible = true;
            else
                this.nudFamACargo.Visible = false;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            SqlConnection cx = null;
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtUsername.Text))
                {
                    MessageBox.Show("Complete el campo usuario", "Error en el Alta Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtUsername.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(this.txtPassword.Text))
                {
                    MessageBox.Show("Complete el campo contraseña", "Error en el Alta Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtPassword.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(this.txtDocumento.Text))
                {
                    MessageBox.Show("Complete el campo Documento", "Error en el Alta Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtPassword.Focus();
                    return;
                }
                Int64 nroAfiliado = (Int64.Parse(this.txtDocumento.Text)) * 100 + this.codigoAfiliado;
                cx = Connection.getConnection();
                cx.Open();
                if (this.codigoAfiliado == 1)
                {
                    SqlCommand sqlCmd = new SqlCommand("PICO_Y_PALA.altaAfiliado", cx);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Add("@afi_nroAfi", SqlDbType.BigInt).Value = nroAfiliado;
                    sqlCmd.Parameters.Add("@afi_username", SqlDbType.VarChar).Value = this.txtUsername.Text;
                    sqlCmd.Parameters.Add("@afi_nro_doc", SqlDbType.BigInt).Value = Int64.Parse(this.txtDocumento.Text);
                    sqlCmd.Parameters.Add("@afi_password", SqlDbType.VarChar).Value = Seguridad.Security.encrypt(this.txtPassword.Text);
                    sqlCmd.Parameters.Add("@afi_nombre", SqlDbType.VarChar).Value = this.txtNombre.Text;
                    sqlCmd.Parameters.Add("@afi_apellido", SqlDbType.VarChar).Value = this.txtApellido.Text;
                    sqlCmd.Parameters.Add("@afi_tipo_doc", SqlDbType.VarChar).Value = this.cbTipoDoc.Text;
                    sqlCmd.Parameters.Add("@afi_direccion", SqlDbType.VarChar).Value = this.txtDireccion.Text;
                    sqlCmd.Parameters.Add("@afi_telefono", SqlDbType.Int).Value = Int32.Parse(this.txtTelefono.Text);
                    sqlCmd.Parameters.Add("@afi_mail", SqlDbType.VarChar).Value = this.txtMail.Text;
                    sqlCmd.Parameters.Add("@afi_fecha_nac", SqlDbType.DateTime).Value = this.dtpFechaNac.Text;
                    sqlCmd.Parameters.Add("@afi_sexo", SqlDbType.Char).Value = this.cbSexo.Text;
                    sqlCmd.Parameters.Add("@afi_plan", SqlDbType.VarChar).Value = this.cbPlan.Text;
                    sqlCmd.Parameters.Add("@afi_eci", SqlDbType.VarChar).Value = this.cbEstadoCivil.Text;
                    //sqlCmd.Parameters.Add("@ok", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    //sqlCmd.Parameters.Add("@enabled", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Dispose();
                }
                else
                {
                    nroAfiliado = (Int64.Parse(this.txtDocAfiTitular.Text)) * 100 + this.codigoAfiliado;
                    SqlCommand sqlCmd = new SqlCommand("PICO_Y_PALA.altaAfiliadoAGrupoFamiliar", cx);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Add("@afi_DocAfiTitular", SqlDbType.BigInt).Value = Int64.Parse(this.txtDocAfiTitular.Text);
                    sqlCmd.Parameters.Add("@afi_nroAfi", SqlDbType.BigInt).Value = nroAfiliado;
                    sqlCmd.Parameters.Add("@afi_username", SqlDbType.VarChar).Value = this.txtUsername.Text;
                    sqlCmd.Parameters.Add("@afi_nro_doc", SqlDbType.BigInt).Value = Int64.Parse(this.txtDocumento.Text);
                    sqlCmd.Parameters.Add("@afi_password", SqlDbType.VarChar).Value = Seguridad.Security.encrypt(this.txtPassword.Text);
                    sqlCmd.Parameters.Add("@afi_nombre", SqlDbType.VarChar).Value = this.txtNombre.Text;
                    sqlCmd.Parameters.Add("@afi_apellido", SqlDbType.VarChar).Value = this.txtApellido.Text;
                    sqlCmd.Parameters.Add("@afi_tipo_doc", SqlDbType.VarChar).Value = this.cbTipoDoc.Text;
                    sqlCmd.Parameters.Add("@afi_direccion", SqlDbType.VarChar).Value = this.txtDireccion.Text;
                    sqlCmd.Parameters.Add("@afi_telefono", SqlDbType.Int).Value = Int32.Parse(this.txtTelefono.Text);
                    sqlCmd.Parameters.Add("@afi_mail", SqlDbType.VarChar).Value = this.txtMail.Text;
                    sqlCmd.Parameters.Add("@afi_fecha_nac", SqlDbType.DateTime).Value = this.dtpFechaNac.Text;
                    sqlCmd.Parameters.Add("@afi_sexo", SqlDbType.Char).Value = this.cbSexo.Text;
                    sqlCmd.Parameters.Add("@afi_plan", SqlDbType.VarChar).Value = this.cbPlan.Text;
                    sqlCmd.Parameters.Add("@afi_eci", SqlDbType.VarChar).Value = this.cbEstadoCivil.Text;
                    //sqlCmd.Parameters.Add("@ok", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    //sqlCmd.Parameters.Add("@enabled", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Dispose();
                }
                cx.Close();
                MessageBox.Show("Afiliado creado con exito. Nro de Afiliado: " + nroAfiliado.ToString());
            }
            catch (Exception exception)
            {
                cx.Close();
                MessageBox.Show(exception.Message);
                return;
            }
            this.Close();
            if ((this.cbEstadoCivil.Text.Equals("Casado") || this.cbEstadoCivil.Text.Equals("Concubinato")) && Mensajes.agregarConyugue())
            {
                    AltaAfiliado familiar = new Abm_Afiliado.AltaAfiliado(this.txtDocumento.Text, 2);
                    familiar.ShowDialog();
            }

            if (this.cbFamACargo.Checked == true)
            {
                this.Close();
                for (int i = 1; i <= nudFamACargo.Value; i++)
                {
                    AltaAfiliado familiar = new Abm_Afiliado.AltaAfiliado(this.txtDocumento.Text, (2+i));
                    familiar.ShowDialog();

                }
            }
        }

    }
}