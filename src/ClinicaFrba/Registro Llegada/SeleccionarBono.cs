using ClinicaFrba.Abm_Afiliado;
using ClinicaFrba.Abm_Profesional;
using ClinicaFrba.BaseDeDatos;
using ClinicaFrba.BaseDeDatos.Componentes;
using ClinicaFrba.Registrar_Agenta_Medico;
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

namespace ClinicaFrba.Registro_Llegada
{
    public partial class SeleccionarBono : Form
    {
        private StringBuilder sqlBono = new StringBuilder();
        private StringBuilder sqlCount = new StringBuilder();
        private StringBuilder sqlAnd = new StringBuilder();
        private Afiliado afiliado;
        private Turno turno;
        private DataSet pagingDS;
        private int scrollVal;
        private int cantBonos;
        private int nroPagina;
        private int cantPaginas;
        private static readonly int CANT_POR_PAGINA = int.Parse(ConfigurationManager.AppSettings["valor.paginacion"]);


        public SeleccionarBono(Afiliado afi, Turno tur)
        {
            InitializeComponent();
            this.afiliado = afi;
            this.turno = tur;
            this.txt_idAfiliado.Text = afiliado.getNroAfiliado();
            this.txt_plan.Text = afiliado.getPlan();
            cargarBonos();
        }

        private void btn_primera_Click(object sender, EventArgs e)
        {
            try
            {
                scrollVal = 0;
                nroPagina = 1;
                ManipulacionComponentes.llenarGrid(dgv_bonosDisponibles, sqlBono.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Bonos");
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
                ManipulacionComponentes.llenarGrid(dgv_bonosDisponibles, sqlBono.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Bonos");
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
                if (scrollVal >= cantBonos)
                {
                    scrollVal = scrollVal - CANT_POR_PAGINA;
                }
                else
                {
                    lbl_nro_pagina.Text = "Página " + ++nroPagina + " de " + cantPaginas;
                }
                ManipulacionComponentes.llenarGrid(dgv_bonosDisponibles, sqlBono.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Bonos");
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
                scrollVal = cantBonos / CANT_POR_PAGINA;
                if (cantBonos % CANT_POR_PAGINA > 0)
                {
                    /*Para que muestre realmente los registros que entrarían en la última página como si hiciésemos "Siguiente"
                     * hasta el final
                     */
                    scrollVal = cantBonos - (cantBonos % CANT_POR_PAGINA);

                }
                else
                {
                    scrollVal = cantBonos - CANT_POR_PAGINA;
                }
                ManipulacionComponentes.llenarGrid(dgv_bonosDisponibles, sqlBono.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Bonos");
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

        private int calcularFilasTotal()
        {
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand(sqlCount.ToString(), cx);
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    sqlReader.Read();
                    return Int32.Parse(sqlReader["total_bonos"].ToString());

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw ex;
                }
            }
        }

        private int idGrupoFamiliar()
        {
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    String unaQuery = "select gfa.agf_gpo_id IdGF from pico_y_pala.gf_afiliado gfa where gfa.agf_afi_nro_doc='"+this.afiliado.getDocumento()+"'";
                    SqlCommand sqlCmd = new SqlCommand(unaQuery, cx);
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    sqlReader.Read();
                    return Int32.Parse(sqlReader["IdGF"].ToString());

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw ex;
                }
            }
        }

        private string idPlan()
        {
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    String unaQuery = "select pla.pla_codigo planID from pico_y_pala.planes pla where pla.pla_desc='" + this.afiliado.getPlan() + "'";
                    SqlCommand sqlCmd = new SqlCommand(unaQuery, cx);
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    sqlReader.Read();
                    return sqlReader["planID"].ToString();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw ex;
                }
            }
        }

        private void cargarBonos()
        {
            try
            {
                ManipulacionComponentes.habilitarComponentes(new List<Control>(){this.btn_primera,this.btn_anterior,this.btn_siguiente,this.btn_ultima,
                                                                              this.btn_seleccionar});
                this.lblCantTurnos.Text = "Cantidad de Bonos";
                scrollVal = 0;
                pagingDS = new DataSet();
                armarQuery();
                ManipulacionComponentes.llenarGrid(dgv_bonosDisponibles, sqlBono.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Bonos");
                dgv_bonosDisponibles.DataSource = pagingDS;
                dgv_bonosDisponibles.DataMember = "Bonos";
                cantBonos = calcularFilasTotal();
                lbl_nroTurno.Text = cantBonos.ToString();
                cantPaginas = cantBonos / CANT_POR_PAGINA;
                nroPagina = 1;
                if (cantBonos % CANT_POR_PAGINA > 0)
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
                MessageBox.Show("Se ha producido un error al buscar bonos: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void armarQuery()
        {

            this.sqlBono.Clear();
            this.sqlCount.Clear();
            sqlBono.Append(ConfigurationManager.AppSettings["query.obtener.bonos.disponinbles.select"].Replace("{2}", idPlan()).Replace("{1}", idGrupoFamiliar().ToString()));
            sqlCount.Append(ConfigurationManager.AppSettings["query.obtener.bonos.disponinbles.count"].Replace("{2}", idPlan()).Replace("{1}", idGrupoFamiliar().ToString()));
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            DateTime horaLlegadaAfi;
            DateTime fechaFinal;
            if (this.dgv_bonosDisponibles.DisplayedRowCount(true) == 0)
            {
                MessageBox.Show("Seleccione un bono de la lista", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (HoraLlegada horaLlegada = new HoraLlegada(this.turno.fechaTurno))
                {
                    if (horaLlegada.ShowDialog().Equals(DialogResult.OK))
                    {
                        horaLlegadaAfi= horaLlegada.fechaReturn;
                        DateTime turFecha = DateTime.Parse(this.turno.fechaTurno);
                        fechaFinal =  new DateTime ( turFecha.Year, turFecha.Month, turFecha.Day, horaLlegadaAfi.Hour, horaLlegadaAfi.Minute, horaLlegadaAfi.Second );
                        
                        SqlConnection cx = null;
                        try
                        {
                            cx = Connection.getConnection();
                            cx.Open();
                            SqlCommand sqlCmd = new SqlCommand("PICO_Y_PALA.registrarLlegada", cx);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.Add("@bonoID", SqlDbType.Int).Value = Int32.Parse(this.dgv_bonosDisponibles.SelectedRows[0].Cells[0].Value.ToString());
                            sqlCmd.Parameters.Add("@afiDoc", SqlDbType.Int).Value = Int32.Parse(this.afiliado.getDocumento());
                            sqlCmd.Parameters.Add("@turnoID", SqlDbType.Int).Value = Int32.Parse(this.turno.idTurno);
                            sqlCmd.Parameters.Add("@fechaTurno", SqlDbType.SmallDateTime).Value = fechaFinal;
                            sqlCmd.ExecuteNonQuery();
                            sqlCmd.Dispose();
                            MessageBox.Show("Se ha generado la consulta y registrado la llegada correctamente!");
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
        }


    }
}
