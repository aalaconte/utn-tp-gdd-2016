using ClinicaFrba.BaseDeDatos;
using ClinicaFrba.BaseDeDatos.Componentes;
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

namespace ClinicaFrba.Listados
{
    public partial class ListadosEstadisticos : Form
    {
        private StringBuilder sql = new StringBuilder();
        private StringBuilder sqlSubq = new StringBuilder();
        private StringBuilder sqlSubqCount = new StringBuilder();

        private DataSet pagingDS;
        private int scrollVal;
        private static readonly int CANT_POR_PAGINA = int.Parse(ConfigurationManager.AppSettings["valor.paginacion"]);


        public ListadosEstadisticos()
        {
            InitializeComponent();
            cb_listados.Items.Add("Top 5 de los profesionales con menos horas trabajadas filtrando Especialidad.");
            cb_listados.Items.Add("Top 5 de las especialidades de médicos con más bonos de consultas utilizados.");
            cb_listados.Items.Add("Top 5 de las especialidades que más se registraron cancelaciones, tanto de afiliados como de profesionales.");
            cb_listados.Items.Add("Top 5 de los afiliados con mayor cantidad de bonos comprados, detallando si pertenece a un grupo familiar.");
            cb_listados.Items.Add("Top 5 de los profesionales más consultados por Especialidad.");
            //Ver si los agregamos tomandolos de las max fechas.
            cb_año.Items.Add("2015");
            cb_año.Items.Add("2016");
            cb_semestre.Items.Add("Primer Semestre");
            cb_semestre.Items.Add("Segundo Semestre");
            ManipulacionComponentes.llenarComboBox(this.cbPlan, "select pla_desc from PICO_Y_PALA.planes", "pla_desc");
                    
        }

        private void cb_listados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_listados.SelectedIndex == 4)
            {
                chb_plan.Visible = true;
                cbPlan.Visible = true;
            }
            else
            {
                chb_plan.Visible = false;
                cbPlan.Visible = false;
            }
        }

        private void cb_semestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_meses.Items.Clear();
            if (cb_semestre.Text.Equals("Primer Semestre"))
            {
                cb_meses.Items.Add("Enero");
                cb_meses.Items.Add("Febrero");
                cb_meses.Items.Add("Marzo");
                cb_meses.Items.Add("Abril");
                cb_meses.Items.Add("Mayo");
                cb_meses.Items.Add("Junio");
            }
            else
            {
                cb_meses.Items.Add("Julio");
                cb_meses.Items.Add("Agosto");
                cb_meses.Items.Add("Septiembre");
                cb_meses.Items.Add("Octubre");
                cb_meses.Items.Add("Noviembre");
                cb_meses.Items.Add("Diciembre");
            }
            if (this.chb_meses.Checked)
                this.cb_meses.SelectedIndex = 0;
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            this.btn_ver.Enabled = false;
            if (ValidacionComponentes.comboBoxSeleccionoOpcion(this.cb_listados))
            {
                try
                {

                    scrollVal = 0;
                    pagingDS = new DataSet();
                    armarQuery(this.cb_listados.SelectedIndex);
                    ManipulacionComponentes.llenarGrid(dgv_listados, sql.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Listado");
                    dgv_listados.DataSource = pagingDS;
                    dgv_listados.DataMember = "Listado";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("Se ha producido un error al cargar el listado: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void armarQuery(int numeroListado)
        {

            this.sql.Clear();
            this.sqlSubq.Clear();
            this.sqlSubqCount.Clear();
            switch (numeroListado)
            {
                case 0:
                    sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.1.select"]);
                    //Año
                    if (ValidacionComponentes.comboBoxSeleccionoOpcion(this.cb_año))
                        sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.1.año"]).Replace("{1}", this.cb_año.Text);
                    else
                    {
                    }
                        //warn label años

                        //Semestre
                        if (this.chb_semestre.Checked && ValidacionComponentes.comboBoxSeleccionoOpcion(this.cb_semestre))
                        {
                            if (this.cb_semestre.Text.Equals("Primer Semestre"))
                                sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.1.PrimerSemestre"]);
                            else
                                sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.1.SegundoSemestre"]);
                        }
                        else
                        {
                            //warn Semestre
                        }
                            
                    //Meses
                            if (this.chb_meses.Checked && ValidacionComponentes.comboBoxSeleccionoOpcion(this.cb_meses))
                            {
                                sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.1.meses"]).Replace("{2}", calcularMes(this.cb_meses.Text));
                            }
                            else
                            {
                            }
                        //warn Semestre

                    //Group y Order by
                    sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.1.group.order"]);
                    break;
                case 1:
                    sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.2.select"]);
                    //Año
                    if (ValidacionComponentes.comboBoxSeleccionoOpcion(this.cb_año))
                        sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.1.año"]).Replace("{1}", this.cb_año.Text);
                    else
                    {
                    }
                        //warn label años

                        //Semestre
                        if (this.chb_semestre.Checked && ValidacionComponentes.comboBoxSeleccionoOpcion(this.cb_semestre))
                        {
                            if (this.cb_semestre.Text.Equals("Primer Semestre"))
                                sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.1.PrimerSemestre"]);
                            else
                                sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.1.SegundoSemestre"]);
                        }
                        else
                        {
                            //warn Semestre
                        }
                            
                    //Meses
                            if (this.chb_meses.Checked && ValidacionComponentes.comboBoxSeleccionoOpcion(this.cb_meses))
                            {
                                sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.1.meses"]).Replace("{2}", calcularMes(this.cb_meses.Text));
                            }
                            else
                            {
                            }
                        //warn Semestre

                    //Group y Order by
                    sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.2.group.order"]);
                    break;
                case 2:
                    //Año
                    if (ValidacionComponentes.comboBoxSeleccionoOpcion(this.cb_año))
                    {
                        sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.3.select"]).Replace("{1}", this.cb_año.Text);
                        this.sqlSubq.Append(ConfigurationManager.AppSettings["query.obtener.listado.3.subquery.select"]).Replace("{1}", this.cb_año.Text);
                        this.sqlSubqCount.Append(ConfigurationManager.AppSettings["query.obtener.listado.3.subquery.count"]).Replace("{1}", this.cb_año.Text);
                    }
                    else
                    {
                    }
                        //warn label años

                        //Semestre
                        if (this.chb_semestre.Checked && ValidacionComponentes.comboBoxSeleccionoOpcion(this.cb_semestre))
                        {
                            if (this.cb_semestre.Text.Equals("Primer Semestre"))
                            {
                                sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.3.PrimerSemestre"]);
                                this.sqlSubq.Append(ConfigurationManager.AppSettings["query.obtener.listado.3.PrimerSemestre.subquery"]);
                                this.sqlSubqCount.Append(ConfigurationManager.AppSettings["query.obtener.listado.3.PrimerSemestre.subquery"]);
                            }
                            else
                            {
                                sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.3.SegundoSemestre"]);
                                this.sqlSubq.Append(ConfigurationManager.AppSettings["query.obtener.listado.3.SegundoSemestre.subquery"]);
                                this.sqlSubqCount.Append(ConfigurationManager.AppSettings["query.obtener.listado.3.SegundoSemestre.subquery"]);
                            }
                        }
                        else
                        {
                            //warn Semestre
                        }
                            
                    //Meses
                            if (this.chb_meses.Checked && ValidacionComponentes.comboBoxSeleccionoOpcion(this.cb_meses))
                            {
                                sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.3.meses"]).Replace("{2}", calcularMes(this.cb_meses.Text));
                                this.sqlSubq.Append(ConfigurationManager.AppSettings["query.obtener.listado.3.meses.subquery"]).Replace("{2}", calcularMes(this.cb_meses.Text));
                                this.sqlSubqCount.Append(ConfigurationManager.AppSettings["query.obtener.listado.3.meses.subquery"]).Replace("{2}", calcularMes(this.cb_meses.Text));
                            }
                            else
                            {
                            }
                        //warn Semestre
                    //Agrego las dos Subquerys armadas
                    sql.Replace("{4}", this.sqlSubq.ToString());
                    sql.Replace("{5}", this.sqlSubqCount.ToString());
                    //Group y Order by
                    sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.3.group.order"]);
                    break;
                case 3:
                    sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.4.select"]);
                    //Año
                    if (ValidacionComponentes.comboBoxSeleccionoOpcion(this.cb_año))
                        sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.4.año"]).Replace("{1}", this.cb_año.Text);
                    else
                    {
                    }
                        //warn label años

                        //Semestre
                        if (this.chb_semestre.Checked && ValidacionComponentes.comboBoxSeleccionoOpcion(this.cb_semestre))
                        {
                            if (this.cb_semestre.Text.Equals("Primer Semestre"))
                                sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.4.PrimerSemestre"]);
                            else
                                sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.4.SegundoSemestre"]);
                        }
                        else
                        {
                            //warn Semestre
                        }
                            
                    //Meses
                            if (this.chb_meses.Checked && ValidacionComponentes.comboBoxSeleccionoOpcion(this.cb_meses))
                            {
                                sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.4.meses"]).Replace("{2}", calcularMes(this.cb_meses.Text));
                            }
                            else
                            {
                            }
                        //warn Semestre

                    //Group y Order by
                    sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.4.group.order"]);
                    break;
                case 4:
                    sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.5.select"]);
                    //Año
                    if (ValidacionComponentes.comboBoxSeleccionoOpcion(this.cb_año))
                        sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.1.año"]).Replace("{1}", this.cb_año.Text);
                    else
                    {
                    }
                        //warn label años

                        //Semestre
                        if (this.chb_semestre.Checked && ValidacionComponentes.comboBoxSeleccionoOpcion(this.cb_semestre))
                        {
                            if (this.cb_semestre.Text.Equals("Primer Semestre"))
                                sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.1.PrimerSemestre"]);
                            else
                                sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.1.SegundoSemestre"]);
                        }
                        else
                        {
                            //warn Semestre
                        }
                            
                    //Meses
                            if (this.chb_meses.Checked && ValidacionComponentes.comboBoxSeleccionoOpcion(this.cb_meses))
                            {
                                sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.1.meses"]).Replace("{2}", calcularMes(this.cb_meses.Text));
                            }
                            else
                            {
                            }
                    //Plan
                            if (this.chb_plan.Checked && ValidacionComponentes.comboBoxSeleccionoOpcion(this.cbPlan))
                            {
                                sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.5.plan"]).Replace("{3}",calcularIdPlan(this.cbPlan.Text));
                            }
                            else
                            {
                                //warn Plan
                            }

                    //Group y Order by
                    sql.Append(ConfigurationManager.AppSettings["query.obtener.listado.5.group.order"]);
                    break;
                default:

                    break;
            }
            this.btn_ver.Enabled = true;
        }

        private String calcularMes(String nombreMes)
        {
            if (nombreMes.Equals("Enero"))
                return "1";
            if (nombreMes.Equals("Febrero"))
                return "2";
            if (nombreMes.Equals("Marzo"))
                return "3";
            if (nombreMes.Equals("Abril"))
                return "4";
            if (nombreMes.Equals("Mayo"))
                return "5";
            if (nombreMes.Equals("Junio"))
                return "6";
            if (nombreMes.Equals("Julio"))
                return "7";
            if (nombreMes.Equals("Agosto"))
                return "8";
            if (nombreMes.Equals("Septiembre"))
                return "9";
            if (nombreMes.Equals("Octubre"))
                return "10";
            if (nombreMes.Equals("Noviembre"))
                return "11";
            if (nombreMes.Equals("Diciembre"))
                return "12";

            return "";
        }

        private void chb_semestre_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chb_semestre.Checked)
            {
                this.cb_semestre.Enabled = true;
                this.cb_semestre.SelectedIndex = 0;
                this.cb_meses.Visible = true;
                this.chb_meses.Visible = true;

            }
            else
            {
                this.cb_semestre.Enabled = false;
                this.cb_meses.Visible = false;
                this.chb_meses.Visible = false;
                this.cb_semestre.SelectedIndex= -1;
                this.chb_meses.Checked = false;
            }
        }

        private void chb_meses_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_meses.Checked)
            {
                this.cb_meses.Enabled = true;
                this.cb_meses.SelectedIndex = 0;
            }
            else
            {
                this.cb_meses.Enabled = false;
                this.cb_meses.SelectedIndex = -1;
            }
        }

        private string calcularIdPlan(string descripcion)
        {
            String unaQuery = "SELECT pla_codigo Codigo FROM PICO_Y_PALA.planes WHERE pla_desc = '"+descripcion+"'";
            string codPlan="";
            using (SqlConnection cx1 = Connection.getConnection())
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand(unaQuery, cx1);
                    cx1.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    sqlReader.Read();
                    codPlan = sqlReader["Codigo"].ToString();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return codPlan;

        }

        private void chb_plan_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chb_plan.Checked)
            {
                this.cbPlan.Enabled = true;
                this.cbPlan.SelectedIndex = 0;


            }
            else
            {
                this.cbPlan.Enabled = false;
                this.cbPlan.SelectedIndex = -1;

            }
        }

        private void cb_año_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(this.cb_listados.SelectedIndex == -1))
            {
                this.chb_semestre.Visible = true;
                this.cb_semestre.Visible = true;
            }
            else
            {
                this.chb_semestre.Visible = false;
                this.cb_semestre.Visible = false;
            }
        }
    }
}
