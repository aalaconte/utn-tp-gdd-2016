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

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class BuscarAfiliado : Form
    {
        public BuscarAfiliado(string operacion)
        {
            InitializeComponent();
            this.btn_seleccionar.Text = operacion;
        }

        private DataSet pagingDS;
        private int scrollVal;
        private int cantAfiliados;
        private int nroPagina;
        private int cantPaginas;
        private StringBuilder sql = new StringBuilder();
        private StringBuilder sqlAnd = new StringBuilder("");
        private static readonly int CANT_POR_PAGINA = int.Parse(ConfigurationManager.AppSettings["valor.paginacion"]);

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                ManipulacionComponentes.habilitarComponentes(new List<Control>(){this.btn_primera,this.btn_anterior,this.btn_siguiente,this.btn_ultima,
                                                                              this.btn_seleccionar});
                this.lblCantAfi.Text = "Cantidad Afiliados";
                scrollVal = 0;
                armarQuery();
                pagingDS = new DataSet();
                ManipulacionComponentes.llenarGrid(dgv_Afiliados, sql.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Afiliados");
                dgv_Afiliados.DataSource = pagingDS;
                dgv_Afiliados.DataMember = "Afiliados";
                //cantAfiliados = (dgv_Afiliados.Rows.Count == 0) ? 1 : dgv_Afiliados.Rows.Count;
                cantAfiliados = calcularFilasTotal();
                lbl_nroAfi.Text = dgv_Afiliados.Rows.Count.ToString();
                cantPaginas = cantAfiliados / CANT_POR_PAGINA;
                nroPagina = 1;
                if (cantAfiliados % CANT_POR_PAGINA > 0)
                {
                    cantPaginas = cantPaginas + 1;
                }
                if (this.cantPaginas == 0)
                { this.cantPaginas++; }

                lbl_nro_pagina.Text = "Página " + nroPagina + " de " + cantPaginas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Se ha producido un error al buscar los afiliados: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void armarQuery()
        {
            sql.Clear();
            sql.Append(ConfigurationManager.AppSettings["query.abm.afiliado.select"]);
            //Armamos los AND
            sqlAnd.Clear();
            if (!string.IsNullOrWhiteSpace(this.txtUsername.Text))
            {
                sqlAnd.Append(ConfigurationManager.AppSettings["query.abm.afiliado.and.username"].Replace("{0}", this.txtUsername.Text));
            }
            if (!string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                sqlAnd.Append(ConfigurationManager.AppSettings["query.abm.afiliado.and.nombre"].Replace("{0}", this.txtNombre.Text));
            }
            if (!string.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                sqlAnd.Append(ConfigurationManager.AppSettings["query.abm.afiliado.and.apellido"].Replace("{0}", this.txtApellido.Text));
            }
            if (!string.IsNullOrWhiteSpace(this.txtDocumento.Text))
            {
                sqlAnd.Append(ConfigurationManager.AppSettings["query.abm.afiliado.and.documento"].Replace("{0}", this.txtDocumento.Text));
            }
            if (!string.IsNullOrWhiteSpace(this.txt_NroAfi.Text))
            {
                sqlAnd.Append(ConfigurationManager.AppSettings["query.abm.afiliado.and.nroAfilado"].Replace("{0}", this.txt_NroAfi.Text));
            }
            
            if (this.cmb_estado.SelectedIndex != -1)
            {
                String valor;
                if (this.cmb_estado.SelectedItem.Equals("SI"))
                {
                    valor = "1";
                }
                else
                {
                    valor = "0";
                }
                sqlAnd.Append(ConfigurationManager.AppSettings["query.abm.afiliado.and.activo"].Replace("{0}", valor));
            }
            sql.Append(sqlAnd);
            sql.Append(ConfigurationManager.AppSettings["query.abm.afiliado.order"]);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (!(this.cantPaginas == this.nroPagina))
            {
                try
                {
                    scrollVal = scrollVal + CANT_POR_PAGINA;
                    if (scrollVal > cantAfiliados)
                    {
                        scrollVal = scrollVal - CANT_POR_PAGINA;
                    }
                    else
                    {
                        lbl_nro_pagina.Text = "Página " + ++nroPagina + " de " + cantPaginas;
                    }
                    ManipulacionComponentes.llenarGrid(dgv_Afiliados, sql.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Afiliados");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("Error al procesar la solicitud: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btn_ultima_Click(object sender, EventArgs e)
        {
            try
            {
                scrollVal = cantAfiliados / CANT_POR_PAGINA;
                if (cantAfiliados % CANT_POR_PAGINA > 0)
                {
                    /*Para que muestre realmente los registros que entrarían en la última página como si hiciésemos "Siguiente"
                     * hasta el final
                     */
                    scrollVal = cantAfiliados - (cantAfiliados % CANT_POR_PAGINA);

                }
                else
                {
                    scrollVal = cantAfiliados - CANT_POR_PAGINA;
                }
                ManipulacionComponentes.llenarGrid(dgv_Afiliados, sql.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Afiliados");
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
                ManipulacionComponentes.llenarGrid(dgv_Afiliados, sql.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Afiliados");
                lbl_nro_pagina.Text = "Página " + nroPagina + " de " + cantPaginas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Error al procesar la solicitud: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (this.dgv_Afiliados.DisplayedRowCount(true) == 0)
            {
                MessageBox.Show("Seleccione un afiliado de la lista", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (btn_seleccionar.Text.Equals("Seleccionar"))
                {
                    Afiliado afi = new Abm_Afiliado.Afiliado(this.dgv_Afiliados.SelectedRows[0].Cells[0].Value.ToString(), this.dgv_Afiliados.SelectedRows[0].Cells[4].Value.ToString(), this.dgv_Afiliados.SelectedRows[0].Cells[2].Value.ToString(), this.dgv_Afiliados.SelectedRows[0].Cells[1].Value.ToString(), this.dgv_Afiliados.SelectedRows[0].Cells[3].Value.ToString(), this.dgv_Afiliados.SelectedRows[0].Cells[5].Value.ToString(),
                    this.dgv_Afiliados.SelectedRows[0].Cells[6].Value.ToString(), this.dgv_Afiliados.SelectedRows[0].Cells[7].Value.ToString(), this.dgv_Afiliados.SelectedRows[0].Cells[8].Value.ToString(), this.dgv_Afiliados.SelectedRows[0].Cells[10].Value.ToString(), (bool)(this.dgv_Afiliados.SelectedRows[0].Cells[12].Value.ToString().Equals("SI")));
                    this.Close();
                    ModificarAfiliado modificar = new ModificarAfiliado(afi);
                    modificar.ShowDialog();
                }
                else
                {
                    //Baja Afiliado
                }

            }
        }

        private int calcularFilasTotal()
        {
            StringBuilder sqlc = new StringBuilder();
            StringBuilder sqlAndc = new StringBuilder();
            int numeroAfi;
            sqlc.Clear();
            sqlc.Append(ConfigurationManager.AppSettings["query.abm.afiliado.count"]);
            //Armamos los AND
            sqlAndc.Clear();
            if (!string.IsNullOrWhiteSpace(this.txtUsername.Text))
            {
                sqlAndc.Append(ConfigurationManager.AppSettings["query.abm.afiliado.and.username"].Replace("{0}", this.txtUsername.Text));
            }
            if (!string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                sqlAndc.Append(ConfigurationManager.AppSettings["query.abm.afiliado.and.nombre"].Replace("{0}", this.txtNombre.Text));
            }
            if (!string.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                sqlAndc.Append(ConfigurationManager.AppSettings["query.abm.afiliado.and.apellido"].Replace("{0}", this.txtApellido.Text));
            }
            if (!string.IsNullOrWhiteSpace(this.txtDocumento.Text))
            {
                sqlAndc.Append(ConfigurationManager.AppSettings["query.abm.afiliado.and.documento"].Replace("{0}", this.txtDocumento.Text));
            }
            if (!string.IsNullOrWhiteSpace(this.txt_NroAfi.Text))
            {
                sqlAndc.Append(ConfigurationManager.AppSettings["query.abm.afiliado.and.nroAfilado"].Replace("{0}", this.txt_NroAfi.Text));
            }

            if (this.cmb_estado.SelectedIndex != -1)
            {
                String valor;
                if (this.cmb_estado.SelectedItem.Equals("SI"))
                {
                    valor = "1";
                }
                else
                {
                    valor = "0";
                }
                sqlAndc.Append(ConfigurationManager.AppSettings["query.abm.afiliado.and.activo"].Replace("{0}", valor));
            }
            sqlc.Append(sqlAndc);
            String unaQuery = sqlc.ToString();
            using (SqlConnection cx1 = Connection.getConnection())
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand(unaQuery, cx1);
                    cx1.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    sqlReader.Read();
                    numeroAfi = Int32.Parse(sqlReader["Total"].ToString());

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return numeroAfi;

        }

        private void btn_primera_Click(object sender, EventArgs e)
        {
            try
            {
                scrollVal = 0;
                nroPagina = 1;
                ManipulacionComponentes.llenarGrid(dgv_Afiliados, sql.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Afiliados");
                lbl_nro_pagina.Text = "Página " + nroPagina + " de " + cantPaginas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Error al procesar la solicitud: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            ManipulacionComponentes.vaciarTextos(new List<Control>() { this.txt_NroAfi, this.txtApellido, this.txtDocumento, this.txtNombre, this.txtUsername, this.lbl_nro_pagina, this.lbl_nroAfi, this.lblCantAfi });
            this.cmb_estado.SelectedIndex = -1;
            ManipulacionComponentes.vaciarGrid(this.dgv_Afiliados);
            ManipulacionComponentes.deshabilitarComponentes(new List<Control>(){this.btn_primera,this.btn_anterior,this.btn_siguiente,this.btn_ultima,
                                                                              this.btn_seleccionar});
        }

        private void BuscarAfiliado_Load(object sender, EventArgs e)
        {

        }
    }
}
