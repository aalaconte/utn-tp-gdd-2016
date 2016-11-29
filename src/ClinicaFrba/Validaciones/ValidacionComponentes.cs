using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Validaciones
{
    class ValidacionComponentes
    {
        public static bool comboBoxSeleccionoOpcion(ComboBox unCombo)
        {
            return (!unCombo.SelectedIndex.Equals(-1));
        }

        public static bool comboBoxSelecOpciones(List<ComboBox> combos)
        {
            foreach (ComboBox unCombo in combos)
            {
                if (unCombo.SelectedIndex.Equals(-1))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool listBoxSeleccionoOpciones(ListBox unList)
        {
            return (unList.Items.Count > 0);
        }

        public static bool listViewSeleccionoOpciones(ListView unList)
        {
            return (unList.Items.Count > 0);
        }

        public static bool textBoxLlenoCampo(TextBox unTextBox)
        {
            return (!string.IsNullOrWhiteSpace(unTextBox.Text));
        }

        public static bool textBoxesCoincidenTextos(TextBox txtBox1, TextBox txtBox2)
        {
            return txtBox1.Text.Equals(txtBox2.Text);
        }

        public static bool validarNumericoPositivo(TextBox textBox)
        {
            uint result;
            return (uint.TryParse(textBox.Text, out result));

        }

        public static bool textBoxTieneSoloTexto(TextBox txtBox)
        {
            return Regex.IsMatch(txtBox.Text, @"^[a-zA-Z]+$");

        }
    }
}
