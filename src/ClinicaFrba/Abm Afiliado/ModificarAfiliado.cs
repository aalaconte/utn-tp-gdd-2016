using ClinicaFrba.BaseDeDatos;
using ClinicaFrba.BaseDeDatos.Componentes;
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
using ClinicaFrba.Abm_Afiliado;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class ModificarAfiliado : Form
    {
        string planActual;
        public ModificarAfiliado()
        {
            InitializeComponent();
        }

        public ModificarAfiliado(Afiliado unAfi)
        {
            InitializeComponent();
            ManipulacionComponentes.llenarComboBox(this.cbPlan, "select pla_desc from PICO_Y_PALA.planes", "pla_desc");
            this.cbPlan.SelectedIndex = this.cbPlan.FindString(unAfi.getPlan());
            this.planActual = unAfi.getPlan();
            this.txtUsername.Text = unAfi.getUsername();
            this.txtNombre.Text = unAfi.getNombre();
            this.txtApellido.Text = unAfi.getApellido();
            this.txtDocumento.Text = unAfi.getDocumento();
            this.txtMail.Text = unAfi.getMail();
            this.dtpFechaNac.Text = unAfi.getFechaNac();
            this.txtNroAfi.Text = unAfi.getNroAfiliado();
            this.txtTelefono.Text = unAfi.getTelefono();
            this.chbHabilitado.Checked = unAfi.getHabilitado();
            this.txtDireccion.Text = unAfi.getDireccion();
        }

        private void ModificarAfiliado_Load(object sender, EventArgs e)
        {

        }

        private void chbCambiarPlan_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCambiarPlan.Checked)
            {
                this.cbPlan.Enabled = true;
                this.lblMotivo.Visible = true;
                this.txtMotivo.Visible = true;
            }
            else
            {
                this.cbPlan.Enabled = false;
                this.lblMotivo.Visible = false;
                this.txtMotivo.Visible = false;
                this.cbPlan.SelectedIndex = this.cbPlan.FindString(this.planActual);
                this.txtMotivo.Text = "";
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.chbCambiarPlan.Checked && this.cbPlan.Text.Equals(this.planActual))
            {
                MessageBox.Show("No se puede cambiar al mismo Plan al que pertenece.", "Error al Modificar Plan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtUsername.Focus();
                return;
            }
            SqlConnection cx = null;
            try
            {
                cx = Connection.getConnection();
                cx.Open();

                SqlCommand sqlCmd = new SqlCommand("PICO_Y_PALA.modificarAfiliado", cx);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Add("@afi_Doc", SqlDbType.BigInt).Value = Int64.Parse(this.txtDocumento.Text);
                    if (this.chbHabilitado.Checked && !(this.cbPlan.Text.Equals(this.planActual)))
                    {
                        sqlCmd.Parameters.Add("@cambioPlan", SqlDbType.Int).Value = 1;
                    }
                    else
                    {
                        sqlCmd.Parameters.Add("@cambioPlan", SqlDbType.Int).Value = 0;
                    }
                    sqlCmd.Parameters.Add("@afi_MotivoCambio", SqlDbType.VarChar).Value = this.txtMotivo.Text;
                    sqlCmd.Parameters.Add("@afi_planNuevo", SqlDbType.VarChar).Value = this.cbPlan.Text;
                    sqlCmd.Parameters.Add("@afi_planViejo", SqlDbType.VarChar).Value = this.planActual;
                    sqlCmd.Parameters.Add("@afi_direccion", SqlDbType.VarChar).Value = this.txtDireccion.Text;
                    sqlCmd.Parameters.Add("@afi_telefono", SqlDbType.BigInt).Value = Int64.Parse(this.txtTelefono.Text);
                    sqlCmd.Parameters.Add("@afi_mail", SqlDbType.VarChar).Value = this.txtMail.Text;
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Dispose();
                    MessageBox.Show("Afiliado modificado con exito!");
                    cx.Close();
            }
            catch (Exception exception)
            {
                cx.Close();
                MessageBox.Show(exception.Message);
                return;
            }
            this.Close();
        }
    }
}