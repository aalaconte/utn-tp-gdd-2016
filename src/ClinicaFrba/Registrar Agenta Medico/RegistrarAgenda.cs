using ClinicaFrba.Abm_Especialidades_Medicas;
using ClinicaFrba.Abm_Profesional;
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

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public partial class RegistrarAgenda : Form
    {
        private static readonly TimeSpan HORA_MIN_LV = new TimeSpan(07, 00, 00);
        private static readonly TimeSpan HORA_MAX_LV = new TimeSpan(19, 30, 00);
        private static readonly TimeSpan HORA_MIN_SAB = new TimeSpan(10, 00, 00);
        private static readonly TimeSpan HORA_MAX_SAB = new TimeSpan(14, 30, 00);
        TimeSpan incremento = new TimeSpan(0, 30, 0);
        private List<Especialidad> especialidades = new List<Especialidad>();
        private Profesional profesional;

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
            List<String> horariosLV = new List<String>();
            TimeSpan horario = HORA_MIN_LV;
            while (horario <= HORA_MAX_LV)
            {
                horariosLV.Add(horario.ToString());
                horario = horario.Add(incremento);
            }
            ManipulacionComponentes.llenarComboBox(this.cmb_hora_desde_lunes, horariosLV, "");
            ManipulacionComponentes.llenarComboBox(this.cmb_hora_desde_martes, horariosLV, "");
            ManipulacionComponentes.llenarComboBox(this.cmb_hora_desde_miercoles, horariosLV, "");
            ManipulacionComponentes.llenarComboBox(this.cmb_hora_desde_jueves, horariosLV, "");
            ManipulacionComponentes.llenarComboBox(this.cmb_hora_desde_viernes, horariosLV, "");
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
            this.cmb_hora_hasta_lunes.Items.Clear();
            List<String> horariosLV = new List<String>();
            TimeSpan horario = TimeSpan.Parse(this.cmb_hora_desde_lunes.SelectedItem.ToString()).Add(this.incremento);
            while (horario <= HORA_MAX_LV)
            {
                horariosLV.Add(horario.ToString());
                horario = horario.Add(incremento);
            }
            ManipulacionComponentes.llenarComboBox(this.cmb_hora_hasta_lunes, horariosLV, "");
        }


    }
}
