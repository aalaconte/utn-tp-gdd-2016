using ClinicaFrba.BaseDeDatos.Componentes;
using ClinicaFrba.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Resultado
{
    public partial class CargarDiagnostico : Form
    {
        public List<String> enfermadadesReturn { get; set; }
        public List<String> sintomasReturn { get; set; }

        public CargarDiagnostico()
        {
            InitializeComponent();
            enfermadadesReturn = new List<string>();
            sintomasReturn = new List<string>();

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.lbl_warn_lb_enfermedades.Visible = false;
            this.lbl_warn_enfermedades.Visible = false;
            this.lbl_warn_lb_sintomas.Visible = false;
            this.lbl_warn_sintomas.Visible = false;
            if (validar())
            {
                for (int i = 0; i < this.lv_enfermedades.Items.Count; i++)
                {
                    this.enfermadadesReturn.Add(lv_enfermedades.Items[i].Text);
                }
                for (int i = 0; i < this.lv_sintomas.Items.Count; i++)
                {
                    this.sintomasReturn.Add(lv_sintomas.Items[i].Text);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool validar()
        {
            bool validacion = true;
            if (!ValidacionComponentes.listViewSeleccionoOpciones(this.lv_sintomas))
            {
                this.lbl_warn_lb_sintomas.Visible = true;
                validacion = false;
            }
            if (!ValidacionComponentes.listViewSeleccionoOpciones(this.lv_enfermedades))
            {
                this.lbl_warn_lb_enfermedades.Visible = true;
                validacion = false;
            }
            return validacion;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_agregarSintoma_Click(object sender, EventArgs e)
        {
            this.lbl_warn_sintomas.Visible = false;
            if (!string.IsNullOrWhiteSpace(this.txt_sintomas.Text))
            {
                this.lv_sintomas.Items.Add(this.txt_sintomas.Text);
                this.txt_sintomas.Text = "";
            }
            else
            {
                this.lbl_warn_sintomas.Visible = true;
            }
        }

        private void btn_agregarEnfermedad_Click(object sender, EventArgs e)
        {
            this.lbl_warn_enfermedades.Visible = false;
            if (!string.IsNullOrWhiteSpace(this.txt_enfermedades.Text))
            {
                this.lv_enfermedades.Items.Add(this.txt_enfermedades.Text);
                this.txt_enfermedades.Text = "";
            }
            else
            {
                this.lbl_warn_enfermedades.Visible = true;
            }
        }
    }
}
