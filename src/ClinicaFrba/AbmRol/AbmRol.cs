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

namespace ClinicaFrba.AbmRol
{
    public partial class AbmRol : Form
    {
        private Rol rol;

        public AbmRol()
        {
            InitializeComponent();
            this.btn_guardar.Visible = false;
            this.lst_funcionalidades_asignadas.Visible = false;
            this.lbl_funcionalidades_asignadas.Visible = false;
            this.chk_habilitado.Visible = false;
            this.rol = new Rol();
        }

        public AbmRol(Rol unRol)
        {
            InitializeComponent();
            this.rol = unRol;
            this.btn_guardar.Size = this.btn_crear.Size;
            this.btn_crear.Visible = false;
        }

        private void AbmRol_Load(object sender, EventArgs e)
        {
            try
            {
                ManipulacionComponentes.llenarComboBox(this.cmb_funcionalidad, "select fun_desc from PICO_Y_PALA.funcionalidad where fun_id <> 1", "fun_desc");
                this.txt_rol.Text = this.rol.getNombre();
                this.chk_habilitado.Checked = this.rol.getHabilitado();
                ManipulacionComponentes.llenarListBox(this.lst_funcionalidades_a_asignar, ConfigurationManager.AppSettings["query.abm.rol.funcionalidades"].Replace("{0}", this.rol.getNombre()), "fun_desc");
                ManipulacionComponentes.llenarListBox(this.lst_funcionalidades_asignadas, ConfigurationManager.AppSettings["query.abm.rol.funcionalidades"].Replace("{0}", this.rol.getNombre()), "fun_desc");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Se ha producido un error al obtener las funcionalidades", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void lst_funcionalidades_a_asignar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_funcionalidades_a_asignar.Items.Remove(lst_funcionalidades_a_asignar.SelectedItem);
        }

        private void cmb_funcionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_funcionalidad.SelectedIndex != -1 && !lst_funcionalidades_a_asignar.Items.Contains(cmb_funcionalidad.SelectedItem.ToString()))
            {
                lst_funcionalidades_a_asignar.Items.Add(cmb_funcionalidad.SelectedItem.ToString());
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            cmb_funcionalidad.SelectedIndex = -1;
            ManipulacionComponentes.vaciarListBox(lst_funcionalidades_a_asignar);
            txt_rol.Text = "";
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (Mensajes.confirmaCambios())
            {
                if (validar())
                {
                    SqlConnection cx = Connection.getConnection();
                    cx.Open();
                    SqlTransaction tx = cx.BeginTransaction();
                    try
                    {
                        crearRol(cx, tx);
                        foreach (String funcionalidad in this.lst_funcionalidades_a_asignar.Items)
                        {
                            crearRolFuncionalidad(funcionalidad, cx, tx);
                        }
                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        Console.WriteLine(ex.ToString());
                        MessageBox.Show("Se ha producido un error al guardar: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    finally
                    {
                        cx.Close();
                    }
                    Mensajes.operacionExitosa();
                    this.Dispose();
                    this.Close();
                }
            }
        }

        //Para la modificación
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Mensajes.confirmaCambios())
            {
                if (validar())
                {
                    SqlConnection cx = Connection.getConnection();
                    cx.Open();
                    SqlTransaction tx = cx.BeginTransaction();
                    try
                    {
                        if (!this.rol.Equals(txt_rol.Text))
                        {
                            cambiarNombreRol(this.rol.getId(), txt_rol.Text, cx, tx);

                        }


                        foreach (String funcionalidad in this.lst_funcionalidades_a_asignar.Items)
                        {
                            //Si no era una funcionalidad ya asignada, se crea la relación Rol-Funcionalidad
                            if (!this.lst_funcionalidades_asignadas.Items.Contains(funcionalidad))
                            {
                                crearRolFuncionalidad(funcionalidad, cx, tx);
                            }
                        }
                        foreach (String funcionalidad in this.lst_funcionalidades_asignadas.Items)
                        {
                            //Si hay funcionalidades que se desasignan, se borra la relación Rol-Funcionalidad
                            if (!this.lst_funcionalidades_a_asignar.Items.Contains(funcionalidad))
                            {
                                borrarRolFuncionalidad(funcionalidad, cx, tx);
                            }
                        }
                        if (this.rol.getHabilitado() && !this.chk_habilitado.Checked)
                        {
                            deshabilitarRol(this.rol.getId(), cx, tx);
                        }
                        if (!this.rol.getHabilitado() && this.chk_habilitado.Checked)
                        {
                            habilitarRol(this.rol.getId(), cx, tx);
                        }
                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        Console.WriteLine(ex.ToString());
                        MessageBox.Show("Se ha producido un error al guardar: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    finally
                    {
                        cx.Close();
                    }
                    Mensajes.operacionExitosa();
                    this.Dispose();
                    this.Close();
                }
            }
        }

        private bool validar()
        {
            bool retorno = true;
            if (!ValidacionComponentes.textBoxLlenoCampo(this.txt_rol))
            {
                MessageBox.Show("Complete el campo nombre", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txt_rol.Focus();
                retorno = false;
            }
            if (retorno && !ValidacionComponentes.listBoxSeleccionoOpciones(this.lst_funcionalidades_a_asignar))
            {
                if (MessageBox.Show("El rol no tiene funcionalidades a asignar. ¿Desea continuar de todas formas? (Puede cambiar esta situación modificando el rol en otro momento)",
                    "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    retorno = false;
                }
            }
            return retorno;
        }

        private void crearRol(SqlConnection cx, SqlTransaction tx)
        {
            SqlCommand sqlCmd = null;
            try
            {
                sqlCmd = new SqlCommand("PICO_Y_PALA.crearRol", cx, tx);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@rol_nombre", SqlDbType.VarChar).Value = this.txt_rol.Text;
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                sqlCmd.Dispose();
                throw ex;
            }
        }

        private void crearRolFuncionalidad(string unaFuncionalidad, SqlConnection cx, SqlTransaction tx)
        {
            SqlCommand sqlCmd = null;
            try
            {
                sqlCmd = new SqlCommand("PICO_Y_PALA.crearRolFuncionalidad", cx, tx);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@rol_nombre", SqlDbType.VarChar).Value = this.txt_rol.Text;
                sqlCmd.Parameters.Add("@fun_nombre", SqlDbType.VarChar).Value = unaFuncionalidad;
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                sqlCmd.Dispose();
                throw ex;
            }
        }

        private void borrarRolFuncionalidad(string unaFuncionalidad, SqlConnection cx, SqlTransaction tx)
        {
            SqlCommand sqlCmd = null;
            try
            {
                sqlCmd = new SqlCommand("PICO_Y_PALA.borrarRolFuncionalidad", cx, tx);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@rol_nombre", SqlDbType.VarChar).Value = this.txt_rol.Text;
                sqlCmd.Parameters.Add("@fun_nombre", SqlDbType.VarChar).Value = unaFuncionalidad;
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                sqlCmd.Dispose();
                throw ex;
            }
        }

        private void habilitarRol(int idRol, SqlConnection cx, SqlTransaction tx)
        {
            SqlCommand sqlCmd = null;
            try
            {
                sqlCmd = new SqlCommand("PICO_Y_PALA.habilitarRol", cx, tx);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@idRol", SqlDbType.Int).Value = idRol;
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                sqlCmd.Dispose();
                throw ex;
            }
        }

        private void deshabilitarRol(int idRol, SqlConnection cx, SqlTransaction tx)
        {
            SqlCommand sqlCmd = null;
            try
            {
                sqlCmd = new SqlCommand("PICO_Y_PALA.deshabilitarRol", cx, tx);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@idRol", SqlDbType.Int).Value = idRol;
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                sqlCmd.Dispose();
                throw ex;
            }
        }

        private void cambiarNombreRol(int idRol, string nuevoNombre, SqlConnection cx, SqlTransaction tx)
        {
            SqlCommand sqlCmd = null;
            try
            {
                sqlCmd = new SqlCommand("PICO_Y_PALA.cambiarNombreRol", cx, tx);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@idRol", SqlDbType.Int).Value = idRol;
                sqlCmd.Parameters.Add("@rol_nombre_nuevo", SqlDbType.VarChar).Value = this.txt_rol.Text;

                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                sqlCmd.Dispose();
                throw ex;
            }
        }

    }
}
