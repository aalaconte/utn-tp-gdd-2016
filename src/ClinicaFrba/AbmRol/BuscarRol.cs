using ClinicaFrba.BaseDeDatos.Componentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.AbmRol
{
    public partial class BuscarRol : Form
    {
        private string accion;
        private DataSet pagingDS;
        private int scrollVal;
        private int cantRoles;
        private int nroPagina;
        private int cantPaginas;
        private StringBuilder sql = new StringBuilder();
        private StringBuilder sqlWhere = new StringBuilder("");
        private static readonly int CANT_POR_PAGINA = int.Parse(ConfigurationManager.AppSettings["valor.paginacion"]);

        public BuscarRol()
        {
            InitializeComponent();
        }

        public BuscarRol(string accionDeseada)
        {
            accion = accionDeseada;
            InitializeComponent();

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.txt_nombre.Text = "";
            this.cmb_estado.SelectedIndex = -1;
            ManipulacionComponentes.vaciarGrid(this.dgv_roles);
            this.lbl_nro_pagina.Text = "";
            this.lbl_nro_roles.Text = "";
            ManipulacionComponentes.deshabilitarComponentes(new List<Control>(){this.btn_primera,this.btn_anterior,this.btn_siguiente,this.btn_ultima,
                                                                              this.btn_seleccionar});
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                ManipulacionComponentes.habilitarComponentes(new List<Control>(){this.btn_primera,this.btn_anterior,this.btn_siguiente,this.btn_ultima,
                                                                              this.btn_seleccionar});
                armarQuery();
                pagingDS = new DataSet();
                ManipulacionComponentes.llenarGrid(dgv_roles, sql.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Roles");
                dgv_roles.DataSource = pagingDS;
                dgv_roles.DataMember = "Roles";
                cantRoles = (dgv_roles.Rows.Count == 0) ? 1 : dgv_roles.Rows.Count;
                lbl_nro_roles.Text = dgv_roles.Rows.Count.ToString();
                cantPaginas = cantRoles / CANT_POR_PAGINA;
                nroPagina = 1;
                if (cantRoles % CANT_POR_PAGINA > 0)
                {
                    cantPaginas = cantPaginas + 1;
                }
                lbl_nro_pagina.Text = "Página " + nroPagina + " de " + cantPaginas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Se ha producido un error al buscar los roles: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void armarQuery()
        {
            sql.Clear();
            sql.Append(ConfigurationManager.AppSettings["query.abm.rol.select"]);
            //Armamos el where
            sqlWhere.Clear();
            sqlWhere.Append(" WHERE").Append(ConfigurationManager.AppSettings["query.abm.rol.where.nombre"].Replace("{0}", this.txt_nombre.Text));
            if (this.cmb_estado.SelectedIndex != -1)
            {
                String valor;
                if (this.cmb_estado.SelectedItem.Equals("Sí"))
                {
                    valor = "1";
                }
                else
                {
                    valor = "0";
                }
                sqlWhere.Append(" AND").Append(ConfigurationManager.AppSettings["query.abm.rol.where.habilitado"].Replace("{0}", valor));
            }
            sqlWhere.Append(" AND rol_id <> 1");
            sql.Append(sqlWhere);
            sql.Append(ConfigurationManager.AppSettings["query.abm.rol.order"]);
        }

        private void btn_primera_Click(object sender, EventArgs e)
        {
            try
            {
                scrollVal = 0;
                nroPagina = 1;
                ManipulacionComponentes.llenarGrid(dgv_roles, sql.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Roles");
                lbl_nro_pagina.Text = "Página " + nroPagina + " de " + cantPaginas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Error al procesar la solicitud: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                scrollVal = scrollVal - CANT_POR_PAGINA;
                if (scrollVal <= 0)
                {
                    scrollVal = 0;
                    nroPagina = 1;
                }
                else
                {
                    --nroPagina;
                }
                ManipulacionComponentes.llenarGrid(dgv_roles, sql.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Roles");
                lbl_nro_pagina.Text = "Página " + nroPagina + " de " + cantPaginas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Error al procesar la solicitud: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                scrollVal = scrollVal + CANT_POR_PAGINA;
                if (scrollVal > cantRoles)
                {
                    scrollVal = scrollVal - CANT_POR_PAGINA;
                }
                else
                {
                    lbl_nro_pagina.Text = "Página " + ++nroPagina + " de " + cantPaginas;
                }
                ManipulacionComponentes.llenarGrid(dgv_roles, sql.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Roles");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Error al procesar la solicitud: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_ultima_Click(object sender, EventArgs e)
        {
            try
            {
                scrollVal = cantRoles / CANT_POR_PAGINA;
                if (cantRoles % CANT_POR_PAGINA > 0)
                {
                    /*Para que muestre realmente los registros que entrarían en la última página como si hiciésemos "Siguiente"
                     * hasta el final
                     */
                    scrollVal = cantRoles - (cantRoles % CANT_POR_PAGINA);

                }
                else
                {
                    scrollVal = cantRoles - CANT_POR_PAGINA;
                }
                ManipulacionComponentes.llenarGrid(dgv_roles, sql.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Roles");
                nroPagina = cantPaginas;
                lbl_nro_pagina.Text = "Página " + nroPagina + " de " + cantPaginas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Error al procesar la solicitud: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BuscarRol_Load(object sender, EventArgs e)
        {
            try
            {
                ManipulacionComponentes.deshabilitarComponentes(new List<Control>(){this.btn_primera,this.btn_anterior,this.btn_siguiente,this.btn_ultima,
                                                                              this.btn_seleccionar});
                ManipulacionComponentes.llenarComboBox(this.cmb_estado, new List<String>() { "Sí", "No" }, "Habilitado");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Se ha producido un error al cargar la pantalla: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (this.dgv_roles.DisplayedRowCount(true)==0)
            {
                MessageBox.Show("Seleccione un rol de la lista", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Rol rol = new Rol((int)this.dgv_roles.SelectedRows[0].Cells[0].Value,
                        this.dgv_roles.SelectedRows[0].Cells[1].Value.ToString(),
                        (bool)(this.dgv_roles.SelectedRows[0].Cells[2].Value.Equals("Sí")));
                this.Close();
                AbmRol modificar = new AbmRol(rol);
                modificar.ShowDialog();
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
