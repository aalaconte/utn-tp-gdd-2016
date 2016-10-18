using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static String rol;
        public static String user;
        public static String fechaActual;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fechaActual = ConfigurationManager.AppSettings["fechaActualSistema"].ToString();
            new Login.Login().Show();
            Application.Run();
        }
        public static void limpiarVariablesEntorno()
        {
            Program.rol = "";
            Program.user = "";
        }
    }
}
