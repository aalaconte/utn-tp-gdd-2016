using ClinicaFrba;
using ClinicaFrba.Abm_Afiliado;
using ClinicaFrba.AbmRol;
using ClinicaFrba.BaseDeDatos;
using ClinicaFrba.Registrar_Agenta_Medico;
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

namespace ClinicaFrba.Main
{
    public partial class MainPage : Form
    {
        private Login.Login login;

        enum funcionalidades
        {
            ABMRol = 1,
            ABMAfiliado = 4,
            ABMProfesional = 5,
            RegistrarAgenda = 8,
            ComprarBonos = 9,
            PedidoTurno = 10,
            RegistroLlegadaAtMedica = 11,
            RegistroResultadoAtMedica = 12,
            CancelarAtencion = 13,
            ListadoEstadistico = 14
        };

        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(Login.Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            lbl_username.Text = Program.user;
            setearFuncionalidadesBotones();
            visibilizarComponentesSegunRol();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.Login login = new Login.Login();
            login.Show();
        }

        private void setearFuncionalidadesBotones()
        {
            btn_abm_rol.Funcionalidad = (int)funcionalidades.ABMRol;
            btn_ABMAfiliado.Funcionalidad = (int)funcionalidades.ABMAfiliado;
            btn_ABMProfesional.Funcionalidad = (int)funcionalidades.ABMProfesional;
            btn_ComprarBonos.Funcionalidad = (int)funcionalidades.ComprarBonos;
            btn_PedidoTurno.Funcionalidad = (int)funcionalidades.PedidoTurno;
            btn_RegistroLlegadaAtMedica.Funcionalidad = (int)funcionalidades.RegistroLlegadaAtMedica;
            btn_RegistroResultadoAtMedica.Funcionalidad = (int)funcionalidades.RegistroResultadoAtMedica;
            btn_CancelarAtencion.Funcionalidad = (int)funcionalidades.CancelarAtencion;
            btn_ListadoEstadistico.Funcionalidad = (int)funcionalidades.ListadoEstadistico;
            btn_registrar_agenda.Funcionalidad = (int)funcionalidades.RegistrarAgenda;
        }

        private void visibilizarComponentesSegunRol()
        {

            using (SqlConnection cx = Connection.getConnection())
            {
                //Voy a buscar las funcionalidades del rol del usuario
                String query = ConfigurationManager.AppSettings["query.obtener.funcionalidades.rol"].ToString();
                SqlCommand sqlCmd = new SqlCommand(query.Replace("{rolUsuario}", Program.rol), cx);
                sqlCmd.CommandType = CommandType.Text;
                cx.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                List<int?> result = new List<int?>();
                //Guardo las funcionalidades correspondientes al rol del usuario
                while (sqlReader.Read())
                {
                    result.Add((int)sqlReader[0]);
                }
                if (result.Any())
                {
                    /*Por cada boton, me fijo si la funcionalidad que tiene asociada está entre las que tiene el rol del usuario
                     * recientemente obtenidas. En caso afirmativo, se hace visible el botón (Al usuario le corresponde operar eso)
                     */
                    foreach (BotonFuncionalidad boton in this.Controls.OfType<BotonFuncionalidad>())
                    {
                        if (result.Contains(boton.Funcionalidad))
                        {
                            boton.Visible = true;
                        }
                    }
                }
                sqlCmd.Dispose();
            }
        }

        private void btn_abm_rol_Click(object sender, EventArgs e)
        {
            AdministrarRoles abmRol = new AbmRol.AdministrarRoles();
            abmRol.ShowDialog();
        }

        private void btn_ABMAfiliado_Click(object sender, EventArgs e)
        {
            AdministrarAfiliados abmAfi = new Abm_Afiliado.AdministrarAfiliados();
            abmAfi.ShowDialog();
        }

        private void btn_registrar_agenda_Click(object sender, EventArgs e)
        {
            RegistrarAgenda registrarAgenda = new Registrar_Agenta_Medico.RegistrarAgenda();
            registrarAgenda.ShowDialog();
        }

    }
}
