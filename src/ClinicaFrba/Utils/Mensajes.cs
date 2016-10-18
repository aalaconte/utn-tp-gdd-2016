using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Utils
{
    class Mensajes
    {
        public static void operacionExitosa()
        {
            MessageBox.Show("Operación realizada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool confirmaCambios()
        {
            return MessageBox.Show("¿Confirma los cambios?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
