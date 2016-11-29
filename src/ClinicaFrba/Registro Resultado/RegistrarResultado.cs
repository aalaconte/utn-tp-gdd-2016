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

namespace ClinicaFrba.Registro_Resultado
{
    public partial class RegistrarResultado : Form
    {
        private StringBuilder sqlConsulta = new StringBuilder();
        private StringBuilder sqlCount = new StringBuilder();
        private StringBuilder sqlAnd = new StringBuilder();
        private Profesional profesional;
        private Afiliado afiliado;
        private DataSet pagingDS;
        private int scrollVal;
        private int cantConsultas;
        private int nroPagina;
        private int cantPaginas;
        private static readonly int CANT_POR_PAGINA = int.Parse(ConfigurationManager.AppSettings["valor.paginacion"]);

        public RegistrarResultado(String user)
        {
            InitializeComponent();
            long nroPro = Profesional.buscarNroProPorUser(user);
            this.lbl_DocProfesional.Text = nroPro.ToString();
            this.dtp_fechaConsulta.Value = DateTime.Parse(ConfigurationManager.AppSettings["fechaActualSistema"].ToString());
            cargarConsutas();
        }


        private void cargarConsutas()
        {
            try
            {
                ManipulacionComponentes.habilitarComponentes(new List<Control>(){this.btn_primera,this.btn_anterior,this.btn_siguiente,this.btn_ultima,
                                                                              this.btn_seleccionar});
                this.lblCantConsultas.Text = "Cantidad de Consultas:";
                scrollVal = 0;
                pagingDS = new DataSet();
                armarQuery();
                ManipulacionComponentes.llenarGrid(dgv_ConsultasProfesional, sqlConsulta.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Consultas");
                dgv_ConsultasProfesional.DataSource = pagingDS;
                dgv_ConsultasProfesional.DataMember = "Consultas";
                cantConsultas = calcularFilasTotal();
                lbl_nroConsulta.Text = cantConsultas.ToString();
                cantPaginas = cantConsultas / CANT_POR_PAGINA;
                nroPagina = 1;
                if (cantConsultas % CANT_POR_PAGINA > 0)
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
                MessageBox.Show("Se ha producido un error al buscar las Consultas: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void armarQuery()
        {

            this.sqlConsulta.Clear();
            this.sqlCount.Clear();
            sqlConsulta.Append(ConfigurationManager.AppSettings["query.obtener.consulta.select"].Replace("{1}", this.lbl_DocProfesional.Text).Replace("{2}", this.dtp_fechaConsulta.Value.Year.ToString()).Replace("{3}", this.dtp_fechaConsulta.Value.Month.ToString()).Replace("{4}", this.dtp_fechaConsulta.Value.Day.ToString()));
            sqlCount.Append(ConfigurationManager.AppSettings["query.obtener.consulta.count"].Replace("{1}", this.lbl_DocProfesional.Text).Replace("{2}", this.dtp_fechaConsulta.Value.Year.ToString()).Replace("{3}", this.dtp_fechaConsulta.Value.Month.ToString()).Replace("{4}", this.dtp_fechaConsulta.Value.Day.ToString()));
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
                    return Int32.Parse(sqlReader["total_consultas"].ToString());

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw ex;
                }
            }
        }

        private void btn_primera_Click(object sender, EventArgs e)
        {
            try
            {
                scrollVal = 0;
                nroPagina = 1;
                ManipulacionComponentes.llenarGrid(dgv_ConsultasProfesional, sqlConsulta.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Consultas");
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
                ManipulacionComponentes.llenarGrid(dgv_ConsultasProfesional, sqlConsulta.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Consultas");
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
                if (scrollVal >= cantConsultas)
                {
                    scrollVal = scrollVal - CANT_POR_PAGINA;
                }
                else
                {
                    lbl_nro_pagina.Text = "Página " + ++nroPagina + " de " + cantPaginas;
                }
                ManipulacionComponentes.llenarGrid(dgv_ConsultasProfesional, sqlConsulta.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Consultas");
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
                scrollVal = cantConsultas / CANT_POR_PAGINA;
                if (cantConsultas % CANT_POR_PAGINA > 0)
                {
                    /*Para que muestre realmente los registros que entrarían en la última página como si hiciésemos "Siguiente"
                     * hasta el final
                     */
                    scrollVal = cantConsultas - (cantConsultas % CANT_POR_PAGINA);

                }
                else
                {
                    scrollVal = cantConsultas - CANT_POR_PAGINA;
                }
                ManipulacionComponentes.llenarGrid(dgv_ConsultasProfesional, sqlConsulta.ToString(), pagingDS, scrollVal, CANT_POR_PAGINA, "Consultas");
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

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {

            if (this.dgv_ConsultasProfesional.DisplayedRowCount(true) == 0)
            {
                MessageBox.Show("Seleccione una consulta de la lista", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (HoraResultado horaResultado = new HoraResultado(this.dgv_ConsultasProfesional.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    if (horaResultado.ShowDialog().Equals(DialogResult.OK))
                    {
                        //horaLlegadaAfi = horaResultado.fechaReturn;
                        //DateTime turFecha = DateTime.Parse(this.turno.fechaTurno);
                        //fechaFinal = new DateTime(turFecha.Year, turFecha.Month, turFecha.Day, horaLlegadaAfi.Hour, horaLlegadaAfi.Minute, horaLlegadaAfi.Second);

                        if (horaResultado.atendio)
                        {
                            //Se realizo la antencion entonces tengo que cargar el diagnostico
                            using (CargarDiagnostico diagnostico = new CargarDiagnostico())
                            {
                                if (diagnostico.ShowDialog().Equals(DialogResult.OK))
                                {
                                    registrarResultadoConDiagnostico(this.dgv_ConsultasProfesional.SelectedRows[0].Cells[0].Value.ToString(), horaResultado.horaReturn, diagnostico.enfermadadesReturn, diagnostico.sintomasReturn);
                                }
                                else
                                {
                                    return;
                                }
                            }
                        }
                        else
                        {
                            //No se atendio entonces no cargo diagnostico
                            registrarResultadoSinDiagnostico();
                        }


                        this.Close();
                    }
                }


            }
        }



        private void registrarResultadoSinDiagnostico()
        {

            SqlConnection cx = null;
            try
            {
                cx = Connection.getConnection();
                cx.Open();
                SqlCommand sqlCmd = new SqlCommand("PICO_Y_PALA.registarResultadoSinDiagnostico", cx);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@consultaID", SqlDbType.Int).Value = Int32.Parse(this.dgv_ConsultasProfesional.SelectedRows[0].Cells[0].Value.ToString());
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
        }

        private void registrarResultadoConDiagnostico(String idConsulta, DateTime horaResultado, List<String> enfermedades, List<String> sintomas)
        {
            SqlConnection cx = null;
            try
            {
                cx = Connection.getConnection();
                cx.Open();
                SqlCommand sqlCmd = new SqlCommand("PICO_Y_PALA.registarResultadoConDiagnostico", cx);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@consultaID", SqlDbType.Int).Value = Int32.Parse(idConsulta);
                sqlCmd.Parameters.Add("@fechaAtencion", SqlDbType.SmallDateTime).Value = horaResultado;
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                cx.Close();

                for (int i = 0; i < enfermedades.Count; i++)
                {
                    agregarEnfermedad(idConsulta, enfermedades.ElementAt(i));
                }
                for (int i = 0; i < sintomas.Count; i++)
                {
                    agregarSintoma(idConsulta, sintomas.ElementAt(i));
                }
                MessageBox.Show("Se ha registrado el resultado de la consulta correctamente!");
            }
            catch (Exception exception)
            {
                cx.Close();
                MessageBox.Show(exception.Message);
                return;
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarEnfermedad(String idConsulta, String unaEnfermedad)
        {
            SqlConnection cx = null;
            cx = Connection.getConnection();
            cx.Open();
            SqlCommand sqlCmd = new SqlCommand("PICO_Y_PALA.agregarEnfermedadesConsulta", cx);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@consultaID", SqlDbType.Int).Value = Int32.Parse(idConsulta);
            sqlCmd.Parameters.Add("@enfermedad", SqlDbType.VarChar).Value = unaEnfermedad;
            sqlCmd.ExecuteNonQuery();
            sqlCmd.Dispose();
            cx.Close();
        }

        private void agregarSintoma(String idConsulta, String unSintoma)
        {
            SqlConnection cx = null;
            cx = Connection.getConnection();
            cx.Open();
            SqlCommand sqlCmd = new SqlCommand("PICO_Y_PALA.agregarSintomasConsulta", cx);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@consultaID", SqlDbType.Int).Value = Int32.Parse(idConsulta);
            sqlCmd.Parameters.Add("@sintoma", SqlDbType.VarChar).Value = unSintoma;
            sqlCmd.ExecuteNonQuery();
            sqlCmd.Dispose();
            cx.Close();
        }

    }
}
