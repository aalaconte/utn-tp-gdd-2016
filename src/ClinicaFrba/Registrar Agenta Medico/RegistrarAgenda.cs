using ClinicaFrba.Abm_Especialidades_Medicas;
using ClinicaFrba.Abm_Profesional;
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

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public partial class RegistrarAgenda : Form
    {
        private static readonly TimeSpan HORA_MIN_LV = new TimeSpan(07, 00, 00);
        private static readonly TimeSpan HORA_MAX_LV = new TimeSpan(19, 30, 00);
        private static readonly TimeSpan HORA_DESDE_ALMUERZO = new TimeSpan(13, 00, 00);
        private static readonly TimeSpan HORA_HASTA_ALMUERZO = new TimeSpan(14, 00, 00);
        private static readonly TimeSpan HORA_MIN_SAB = new TimeSpan(10, 00, 00);
        private static readonly TimeSpan HORA_MAX_SAB = new TimeSpan(14, 30, 00);
        private static readonly double MAXIMO_HORAS = double.Parse(ConfigurationManager.AppSettings["max.horas.semanales.profesional"].ToString());
        private List<ComboBox> combosLunes = new List<ComboBox>();
        private List<ComboBox> combosMartes = new List<ComboBox>();
        private List<ComboBox> combosMiercoles = new List<ComboBox>();
        private List<ComboBox> combosJueves = new List<ComboBox>();
        private List<ComboBox> combosViernes = new List<ComboBox>();
        private List<ComboBox> combosSabado = new List<ComboBox>();
        TimeSpan incremento = new TimeSpan(0, 30, 0);
        private List<Especialidad> especialidades = new List<Especialidad>();
        private Profesional profesional;
        private double totalHoras = 0;

        public RegistrarAgenda()
        {
            InitializeComponent();
        }

        private void chk_viernes_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Cancelar click
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void RegistrarAgenda_Load(object sender, EventArgs e)
        {
            this.cargarComboBoxLists();
            List<String> horarios = new List<String>();
            TimeSpan horario = HORA_MIN_LV;
            while (horario <= HORA_MAX_LV)
            {
                horarios.Add(horario.ToString());
                horario = horario.Add(incremento);
            }
            ManipulacionComponentes.llenarComboBox(this.cmb_hora_desde_lunes, horarios, "");
            ManipulacionComponentes.llenarComboBox(this.cmb_hora_desde_martes, horarios, "");
            ManipulacionComponentes.llenarComboBox(this.cmb_hora_desde_miercoles, horarios, "");
            ManipulacionComponentes.llenarComboBox(this.cmb_hora_desde_jueves, horarios, "");
            ManipulacionComponentes.llenarComboBox(this.cmb_hora_desde_viernes, horarios, "");
            horarios = new List<String>();
            horario = HORA_MIN_SAB;
            while (horario <= HORA_MAX_SAB)
            {
                horarios.Add(horario.ToString());
                horario = horario.Add(incremento);
            }
            ManipulacionComponentes.llenarComboBox(this.cmb_hora_desde_sabado, horarios, "");
        }

        private void btn_buscar_profesional_Click(object sender, EventArgs e)
        {
            using (BuscarProfesionales buscarProfesional = new BuscarProfesionales())
            {
                if (buscarProfesional.ShowDialog().Equals(DialogResult.OK))
                {
                    this.profesional = buscarProfesional.ProfesionalReturn;
                    this.txt_profesional.Text = this.profesional.Apellido + ", " + this.profesional.Nombre;
                }
            }

        }

        private void txt_profesional_TextChanged(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sqlEspecialidadesProfesional = new StringBuilder(ConfigurationManager.AppSettings["query.obtener.especialidades.profesional.select"]);
                sqlEspecialidadesProfesional.Append(" WHERE");
                sqlEspecialidadesProfesional.Append(ConfigurationManager.AppSettings["query.obtener.profesionales.where.nro.doc"].Replace("{2}", this.profesional.NroDoc.ToString()));
                ManipulacionComponentes.llenarComboBox(this.cmb_especialidades, sqlEspecialidadesProfesional.ToString(), "Especialidad");
                this.cmb_especialidades.DropDownWidth = ManipulacionComponentes.obtenerDropDownMaxWidthCombo(this.cmb_especialidades);
                this.especialidades = obtenerEspecialidadesProfesional(this.profesional.NroDoc, sqlEspecialidadesProfesional.ToString());
                this.totalHoras = 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Se produjo un error al consultar las especialidades del profesional: " + this.txt_profesional.Text, "Error en el login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private List<Especialidad> obtenerEspecialidadesProfesional(int nroDoc, String query)
        {
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand(query, cx);
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    List<Especialidad> especialidadesLocal = new List<Especialidad>();

                    while (sqlReader.Read())
                    {
                        especialidadesLocal.Add(new Especialidad(int.Parse(sqlReader["ID"].ToString()), sqlReader["Especialidad"].ToString()));
                    }

                    return especialidadesLocal;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void chk_lunes_CheckedChanged(object sender, EventArgs e)
        {
            this.cmb_hora_desde_lunes.Enabled = this.chk_lunes.Checked;
            this.cmb_hora_hasta_lunes.Enabled = this.chk_lunes.Checked;
        }

        private void chk_martes_CheckedChanged(object sender, EventArgs e)
        {
            this.cmb_hora_desde_martes.Enabled = this.chk_martes.Checked;
            this.cmb_hora_hasta_martes.Enabled = this.chk_martes.Checked;
        }

        private void chk_miercoles_CheckedChanged(object sender, EventArgs e)
        {
            this.cmb_hora_desde_miercoles.Enabled = this.chk_miercoles.Checked;
            this.cmb_hora_hasta_miercoles.Enabled = this.chk_miercoles.Checked;
        }

        private void chk_jueves_CheckedChanged(object sender, EventArgs e)
        {
            this.cmb_hora_desde_jueves.Enabled = this.chk_jueves.Checked;
            this.cmb_hora_hasta_jueves.Enabled = this.chk_jueves.Checked;
        }

        private void chk_viernes_CheckedChanged_1(object sender, EventArgs e)
        {
            this.cmb_hora_desde_viernes.Enabled = this.chk_viernes.Checked;
            this.cmb_hora_hasta_viernes.Enabled = this.chk_viernes.Checked;
        }

        private void chk_sabado_CheckedChanged(object sender, EventArgs e)
        {
            this.cmb_hora_desde_sabado.Enabled = this.chk_sabado.Checked;
            this.cmb_hora_hasta_sabado.Enabled = this.chk_sabado.Checked;
        }

        private void cmb_hora_desde_lunes_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarComboHorarioHasta(this.cmb_hora_desde_lunes.SelectedItem.ToString(), this.cmb_hora_hasta_lunes, HORA_MAX_LV, false);
        }

        private void cmb_hora_desde_martes_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarComboHorarioHasta(this.cmb_hora_desde_martes.SelectedItem.ToString(), this.cmb_hora_hasta_martes, HORA_MAX_LV, false);
        }

        private void cmb_hora_desde_miercoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarComboHorarioHasta(this.cmb_hora_desde_miercoles.SelectedItem.ToString(), this.cmb_hora_hasta_miercoles, HORA_MAX_LV, false);
        }

        private void cmb_hora_desde_jueves_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarComboHorarioHasta(this.cmb_hora_desde_jueves.SelectedItem.ToString(), this.cmb_hora_hasta_jueves, HORA_MAX_LV, false);
        }

        private void cmb_hora_desde_viernes_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarComboHorarioHasta(this.cmb_hora_desde_viernes.SelectedItem.ToString(), this.cmb_hora_hasta_viernes, HORA_MAX_LV, false);
        }

        private void cmb_hora_desde_sabado_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarComboHorarioHasta(this.cmb_hora_desde_sabado.SelectedItem.ToString(), this.cmb_hora_hasta_sabado, HORA_MAX_SAB, true);
        }

        private void llenarComboHorarioHasta(String horaDesde, ComboBox comboHasta, TimeSpan horaMax, bool esSabado)
        {
            comboHasta.Items.Clear();
            List<String> horarios = new List<String>();
            TimeSpan horario = TimeSpan.Parse(horaDesde).Add(this.incremento);
            while (horario <= horaMax)
            {
                horarios.Add(horario.ToString());
                horario = horario.Add(incremento);
            }
            ManipulacionComponentes.llenarComboBox(comboHasta, horarios, "");
        }

        private void cargarComboBoxLists()
        {
            this.combosLunes.AddRange(new ComboBox[] { this.cmb_hora_desde_lunes, this.cmb_hora_hasta_lunes });
            this.combosMartes.AddRange(new ComboBox[] { this.cmb_hora_desde_martes, this.cmb_hora_hasta_martes });
            this.combosMiercoles.AddRange(new ComboBox[] { this.cmb_hora_desde_miercoles, this.cmb_hora_hasta_miercoles });
            this.combosJueves.AddRange(new ComboBox[] { this.cmb_hora_desde_jueves, this.cmb_hora_hasta_jueves });
            this.combosViernes.AddRange(new ComboBox[] { this.cmb_hora_desde_viernes, this.cmb_hora_hasta_viernes });
            this.combosSabado.AddRange(new ComboBox[] { this.cmb_hora_desde_sabado, this.cmb_hora_hasta_sabado });
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                using (SqlConnection cx = Connection.getConnection())
                {
                    SqlTransaction tx = null;
                    try
                    {
                        cx.Open();
                        tx = cx.BeginTransaction();
                        this.totalHoras = 0;
                        this.totalHoras += TimeSpan.Parse(this.cmb_hora_hasta_lunes.SelectedItem.ToString()).Subtract(TimeSpan.Parse(this.cmb_hora_hasta_lunes.SelectedItem.ToString())).TotalHours;
                        //this.totalHoras += TimeSpan.Parse(this.cmb_hora_hasta_martes.SelectedItem.ToString()).Subtract(TimeSpan.Parse(this.cmb_hora_hasta_martes.SelectedItem.ToString())).TotalHours;
                        //this.totalHoras += TimeSpan.Parse(this.cmb_hora_hasta_miercoles.SelectedItem.ToString()).Subtract(TimeSpan.Parse(this.cmb_hora_hasta_miercoles.SelectedItem.ToString())).TotalHours;
                        //this.totalHoras += TimeSpan.Parse(this.cmb_hora_hasta_jueves.SelectedItem.ToString()).Subtract(TimeSpan.Parse(this.cmb_hora_hasta_jueves.SelectedItem.ToString())).TotalHours;
                        //this.totalHoras += TimeSpan.Parse(this.cmb_hora_hasta_viernes.SelectedItem.ToString()).Subtract(TimeSpan.Parse(this.cmb_hora_hasta_viernes.SelectedItem.ToString())).TotalHours;
                        //this.totalHoras += TimeSpan.Parse(this.cmb_hora_hasta_sabado.SelectedItem.ToString()).Subtract(TimeSpan.Parse(this.cmb_hora_hasta_sabado.SelectedItem.ToString())).TotalHours;
                        Especialidad espSeleccionada = this.especialidades.Find(especialidad => especialidad.Descripcion.Equals(this.cmb_especialidades.SelectedItem.ToString()));
                        List<AgendaProfesional> agendasConflictoLunes = new List<AgendaProfesional>();
                        if (!procesarRegistrarAgenda(2, this.profesional.NroDoc, espSeleccionada.Id, TimeSpan.Parse(this.cmb_hora_desde_lunes.Text), TimeSpan.Parse(this.cmb_hora_hasta_lunes.Text), this.lbl_error_lunes, this.cmb_error_lunes, cx, tx))
                        {
                            agendasConflictoLunes = obtenerAgendasConflictoProfesionalDia(this.profesional, new Dia(2, "Lunes"), this.cmb_hora_desde_lunes.Text, this.cmb_hora_hasta_lunes.Text, cx, tx);
                            foreach (AgendaProfesional agenda in agendasConflictoLunes)
                            {
                                this.lbl_error_lunes.Visible = true;
                                foreach (Especialidad especialidad in agenda.Profesional.Especialidades){
                                    this.cmb_error_lunes.Items.Add(especialidad.Descripcion + " - " + agenda.hhDesde.ToString() + " - " + agenda.hhHasta.ToString());
                                    this.cmb_error_lunes.Visible = true;
                                    this.cmb_error_lunes.DropDownWidth = ManipulacionComponentes.obtenerDropDownMaxWidthCombo(this.cmb_error_lunes);
                                }
                            }
                        }


                                    //SqlDataReader sqlReader = 
                                    //while (sqlReader.Read())
                                    //{
                                    //    lblError.Visible = true;
                                    //    cmbError.Visible = true;
                                    //    StringBuilder item = new StringBuilder(sqlReader["especialidad"].ToString());
                                    //    item.Append(" - ").Append(sqlReader["desde"].ToString());
                                    //    item.Append(" - ").Append(sqlReader["hasta"].ToString());
                                    //    cmbError.Items.Add(item.ToString());
                                    //    cmbError.DropDownWidth = ManipulacionComponentes.obtenerDropDownMaxWidthCombo(cmbError);
                                    //}
                                    //sqlReader.Close();
                                    //return (double)(decimal)sqlCmd.Parameters["@totalHoras"].Value;
                        if (!this.lbl_error_lunes.Visible && this.totalHoras <= MAXIMO_HORAS)
                        {
                            tx.Commit();
                            this.Close();

                        }
                        else
                        {
                            tx.Rollback();
                            //MessageBox.Show("Se produjo un error al registrar las agendas: " + this.txt_profesional.Text, "Error en el login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        if (tx != null) tx.Rollback();
                        Console.WriteLine(ex);
                        MessageBox.Show("Se produjo un error al registrar las agendas: " + this.txt_profesional.Text, "Error en el login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
                    }
                }
            }
        }

        private List<AgendaProfesional> obtenerAgendasConflictoProfesionalDia(Profesional profesional, Dia dia, String hhDesde, String hhHasta, SqlConnection cx, SqlTransaction tx)
        {
            List<AgendaProfesional> agendasReturn = new List<AgendaProfesional>();
            StringBuilder query = new StringBuilder(ConfigurationManager.AppSettings["query.obtener.agendas.select"].ToString());
            query.Append(ConfigurationManager.AppSettings["query.obtener.agendas.group.by"].ToString());
            query.Append(" HAVING");
            query.Append(ConfigurationManager.AppSettings["query.obtener.agendas.having.profesional"].Replace("{0}",this.profesional.NroDoc.ToString()).ToString());
            query.Append(" AND");
            query.Append(ConfigurationManager.AppSettings["query.obtener.agendas.having.dia"].Replace("{1}", dia.Id.ToString()).ToString());
            query.Append(" AND");
            query.Append(ConfigurationManager.AppSettings["query.obtener.agendas.having.horario.conflicto"].Replace("{4}", '\'' + hhDesde + '\'').Replace("{5}", '\'' + hhHasta + '\'').ToString());
            SqlCommand sqlCmd = new SqlCommand(query.ToString(), cx, tx);
            sqlCmd.CommandType = CommandType.Text;
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            AgendaProfesional agenda = new AgendaProfesional();
            agenda.Profesional = new Profesional(profesional.Apellido, profesional.Nombre);
            agenda.Profesional.Especialidades = new List<Especialidad>();
            while (sqlReader.Read())
            {
                agenda.Dia = dia;
                agenda.Profesional.Especialidades.Add(new Especialidad((int)sqlReader["esp_id"],sqlReader["especialidad"].ToString()));
                agenda.hhDesde = TimeSpan.Parse(sqlReader["desde"].ToString());
                agenda.hhHasta = TimeSpan.Parse(sqlReader["hasta"].ToString());
                agendasReturn.Add(agenda);
            }
            sqlReader.Close();
            sqlReader.Dispose();
            
            return agendasReturn;

        }

        private bool procesarRegistrarAgenda(int idDia, int nroDocProfesional, int idEspecialidad, TimeSpan hhDesde, TimeSpan hhHasta, Label lblError, ComboBox cmbError, SqlConnection cx, SqlTransaction tx)
        {
            

            SqlCommand sqlCmd = new SqlCommand("PICO_Y_PALA.registrarAgenda", cx, tx);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@dia", SqlDbType.Int).Value = idDia;
            sqlCmd.Parameters.Add("@nroDocProf", SqlDbType.Decimal).Value = nroDocProfesional;
            sqlCmd.Parameters.Add("@esp", SqlDbType.Int).Value = idEspecialidad;
            sqlCmd.Parameters.Add("@hhDesde", SqlDbType.Time).Value = hhDesde;
            sqlCmd.Parameters.Add("@hhHasta", SqlDbType.Time).Value = hhHasta;
            sqlCmd.Parameters.Add("@maxHoras", SqlDbType.Decimal).Value = MAXIMO_HORAS;
            sqlCmd.Parameters.Add("@totalHoras", SqlDbType.Decimal).Direction = ParameterDirection.Output;
            sqlCmd.Parameters.Add("@inserted", SqlDbType.Bit).Direction = ParameterDirection.Output;
            sqlCmd.ExecuteNonQuery();

            return (bool)sqlCmd.Parameters["@inserted"].Value;

        }

        private bool validarCampos()
        {
            bool validacion = true;
            this.lbl_error_lunes.Visible = false; this.lbl_error_martes.Visible = false; this.lbl_error_miercoles.Visible = false;
            this.lbl_error_jueves.Visible = false; this.lbl_error_viernes.Visible = false; this.lbl_error_sabado.Visible = false;
            this.cmb_error_lunes.Visible = false; this.cmb_error_martes.Visible = false; this.cmb_error_miercoles.Visible = false;
            this.cmb_error_jueves.Visible = false; this.cmb_error_viernes.Visible = false; this.cmb_error_sabado.Visible = false;
            this.cmb_error_lunes.Items.Clear(); this.cmb_error_martes.Items.Clear(); this.cmb_error_miercoles.Items.Clear();
            this.cmb_error_jueves.Items.Clear(); this.cmb_error_viernes.Items.Clear(); this.cmb_error_sabado.Items.Clear();
            this.lbl_warn_especialidad.Visible = false; this.lbl_warn_horarios.Visible = false; this.lbl_warn_profesional.Visible = false;
            this.lbl_error_horas_profesional.Text = "Con las agendas generadas, el profesional acumularía {0} hs semanales. El máximo permitido son 48 hs.";
            this.lbl_error_horas_profesional.Visible = false;

            if (!ValidacionComponentes.textBoxLlenoCampo(this.txt_profesional))
            {
                this.lbl_warn_profesional.Visible = true;
                validacion = false;
            }
            if (!ValidacionComponentes.comboBoxSeleccionoOpcion(this.cmb_especialidades))
            {
                this.lbl_warn_especialidad.Visible = true;
                validacion = false;
            }
            if (this.chk_lunes.Checked && !ValidacionComponentes.comboBoxSelecOpciones(combosLunes))
            {
                this.lbl_warn_horarios.Visible = true;
                validacion = false;
            }
            if (this.chk_martes.Checked && !ValidacionComponentes.comboBoxSelecOpciones(combosMartes))
            {
                this.lbl_warn_horarios.Visible = true;
                validacion = false;
            }
            if (this.chk_miercoles.Checked && !ValidacionComponentes.comboBoxSelecOpciones(combosMiercoles))
            {
                this.lbl_warn_horarios.Visible = true;
                validacion = false;
            }
            if (this.chk_jueves.Checked && !ValidacionComponentes.comboBoxSelecOpciones(combosJueves))
            {
                this.lbl_warn_horarios.Visible = true;
                validacion = false;
            }
            if (this.chk_viernes.Checked && !ValidacionComponentes.comboBoxSelecOpciones(combosViernes))
            {
                this.lbl_warn_horarios.Visible = true;
                validacion = false;
            }
            if (this.chk_sabado.Checked && !ValidacionComponentes.comboBoxSelecOpciones(combosSabado))
            {
                this.lbl_warn_horarios.Visible = true;
                validacion = false;
            }
            return validacion;
        }

        private void lbl_error_lunes_Click(object sender, EventArgs e)
        {

        }

        private void cmb_especialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.totalHoras = 0;
        }

    }
}
