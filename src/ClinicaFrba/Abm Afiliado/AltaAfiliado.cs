using ClinicaFrba.BaseDeDatos;
using ClinicaFrba.BaseDeDatos.Componentes;
using ClinicaFrba.Utils;
using ClinicaFrba.Validaciones;
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

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class AltaAfiliado : Form
    {
        private int codigoAfiliado;
        private Afiliado afiliadoBuscar;
        public AltaAfiliado()
        {
            InitializeComponent();
            this.codigoAfiliado = 1;
            this.dtpFechaNac.Value = DateTime.Parse(ConfigurationManager.AppSettings["fechaActualSistema"].ToString());
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
                this.cbTipoDoc.Items.Add("DNI");
                this.cbTipoDoc.Items.Add("LC");
                this.cbTipoDoc.Items.Add("LR");
                this.cbTipoDoc.Items.Add("PAS");

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
            limpiarWarnings();
            if (validar())
            {
                SqlConnection cx = null;
                try
                {


                    Int64 nroAfiliado = (Int64.Parse(this.txtDocumento.Text)) * 100 + this.codigoAfiliado;
                    cx = Connection.getConnection();
                    cx.Open();
                    if (this.codigoAfiliado == 1 && chbGrupoFamiliar.Checked == false)
                    {   //Caso donde el afiliado es el titular de su grupo familiar
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
                    else if (this.codigoAfiliado != 1)
                    {   //caso donde el titular Asoscia a sus familiares a cargo o conyugue
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
                    else //Caso que un nuevo Afiliado se quiera agregar a un grupo familiar
                    {
                        this.codigoAfiliado = calcularCodigoAfiliado(this.txtDocAfiTitular.Text);
                        //Dos es para conyugue, chequear como hacer para evitar
                        if ((this.cbEstadoCivil.Text.Equals("Casado") || this.cbEstadoCivil.Text.Equals("Concubinato")) && !tieneConyugue(this.txtDocAfiTitular.Text))
                        {
                            this.codigoAfiliado = 2;
                        }

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
                if ((this.cbEstadoCivil.Text.Equals("Casado") || this.cbEstadoCivil.Text.Equals("Concubinato")) && chbGrupoFamiliar.Checked == false && Mensajes.agregarConyugue())
                {
                    AltaAfiliado familiar = new Abm_Afiliado.AltaAfiliado(this.txtDocumento.Text, 2);
                    familiar.ShowDialog();
                }

                if (this.cbFamACargo.Checked == true)
                {
                    this.Close();
                    for (int i = 1; i <= nudFamACargo.Value; i++)
                    {
                        AltaAfiliado familiar = new Abm_Afiliado.AltaAfiliado(this.txtDocumento.Text, (2 + i));
                        familiar.ShowDialog();

                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor complete los campos faltantes.", "Error al Crear Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private int calcularCodigoAfiliado(String docAfiliadoTitular)
        {
            long numeroAfi=0;
            long codigoAfi;
            String unaQuery = "select top 1 afi.afi_nro_afiliado as numeroAfiliado from pico_y_pala.grupo_familiar gf, pico_y_pala.gf_afiliado gf_a, pico_y_pala.afiliado afi where gf.gpo_id=gf_a.agf_gpo_id and gf.gpo_titular="+docAfiliadoTitular+" and gf_a.agf_afi_nro_doc=afi.afi_nro_doc order by numeroAfiliado desc";
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand(unaQuery, cx);
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        numeroAfi = Int64.Parse(sqlReader["numeroAfiliado"].ToString());
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            codigoAfi = numeroAfi - Int64.Parse(docAfiliadoTitular) * 100+1;

            return (int)codigoAfi;
        }

        bool tieneConyugue(String docAfiliadoTitular)
        {
            long numeroAfi = 0;
            String unaQuery = "select afi.afi_nro_afiliado as conyugue from pico_y_pala.grupo_familiar gf, pico_y_pala.gf_afiliado gf_a, pico_y_pala.afiliado afi where gf.gpo_id=gf_a.agf_gpo_id and gf.gpo_titular="+docAfiliadoTitular+" and gf_a.agf_afi_nro_doc=afi.afi_nro_doc and afi.afi_nro_afiliado LIKE '%02'";
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand(unaQuery, cx);
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        numeroAfi = Int64.Parse(sqlReader["conyugue"].ToString());
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            if (numeroAfi != 0)
                return true;
            else
                return false;
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validar()
        {
            bool resultado = true;
            if (string.IsNullOrWhiteSpace(this.txtUsername.Text))
            {
                this.lbl_warn_usuario.Visible = true;
                resultado = false;
            }
            if (string.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                this.lbl_warn_pass.Visible = true;
                resultado = false;
            }
            if (string.IsNullOrWhiteSpace(this.txtDocumento.Text) || !ValidacionComponentes.validarNumericoPositivo(txtDocumento))
            {
                this.lbl_warn_doc.Visible = true;
                resultado = false;
            }
            if (string.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                this.lbl_warn_ape.Visible = true;
                resultado = false;
            }
            if (string.IsNullOrWhiteSpace(this.txtDireccion.Text))
            {
                this.lbl_warn_dir.Visible = true;
                resultado = false;
            }
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                this.lbl_warn_nom.Visible = true;
                resultado = false;
            }
            if (string.IsNullOrWhiteSpace(this.txtTelefono.Text) || !ValidacionComponentes.validarNumericoPositivo(txtTelefono))
            {
                this.lbl_warn_tel.Visible = true;
                resultado = false;
            }
            if (string.IsNullOrWhiteSpace(this.txtMail.Text))
            {
                this.lbl_warn_mail.Visible = true;
                resultado = false;
            }
            if (!ValidacionComponentes.comboBoxSeleccionoOpcion(cbEstadoCivil))
            {
                this.lbl_warn_ec.Visible = true;
                resultado = false;
            }
            if (!ValidacionComponentes.comboBoxSeleccionoOpcion(cbPlan))
            {
                this.lbl_warn_plan.Visible = true;
                resultado = false;
            }
            if (!ValidacionComponentes.comboBoxSeleccionoOpcion(cbSexo))
            {
                this.lbl_warn_sexo.Visible = true;
                resultado = false;
            }
            if (!ValidacionComponentes.comboBoxSeleccionoOpcion(cbTipoDoc))
            {
                this.lbl_warn_tdoc.Visible = true;
                resultado = false;
            }
            if (this.dtpFechaNac.Value > DateTime.Parse(ConfigurationManager.AppSettings["fechaActualSistema"].ToString()))
            {
                this.lbl_warn_fecha.Visible = true;
                resultado = false;
            }

                return resultado;
        }

        private void limpiarWarnings()
        {

            ManipulacionComponentes.ocultarComponentes(new List<Control>{this.lbl_warn_tdoc, this.lbl_warn_ape, this.lbl_warn_dir, this.lbl_warn_doc, this.lbl_warn_ec, this.lbl_warn_fecha, this.lbl_warn_mail, this.lbl_warn_nom, this.lbl_warn_pass, this.lbl_warn_plan, this.lbl_warn_sexo, this.lbl_warn_tdoc, this.lbl_warn_tel, this.lbl_warn_usuario});
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
            using (BuscarAfiliado buscarAfi = new BuscarAfiliado("Seleccionar"))
            {
                if (buscarAfi.ShowDialog().Equals(DialogResult.OK))
                {
                    this.afiliadoBuscar = buscarAfi.AfiliadoReturn;
                    if (this.afiliadoBuscar.getHabilitado())
                        this.txtDocAfiTitular.Text = this.afiliadoBuscar.getDocumento();
                    else
                        MessageBox.Show("El afiliado seleccionado no se encuentra habilitado para realizar esta operacion", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

    }
}