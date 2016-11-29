using ClinicaFrba.Abm_Afiliado;
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

namespace ClinicaFrba.Compra_Bono
{
    public partial class CompraBonos : Form
    {
        Afiliado afiliado;
        public CompraBonos()
        {
            InitializeComponent();
            this.txtNroAfi.Enabled = true;
            this.btnBuscar.Visible = true;
        }

        public CompraBonos(String user)
        {
            InitializeComponent();
            long nroAfi = Afiliado.buscarNroAfiporUser(user);
            this.txtNroAfi.Text = nroAfi.ToString();
            if (cargarDatosBono(nroAfi.ToString()))
            {
                ManipulacionComponentes.verComponentes(new List<Control>() { this.lblCant, this.lblPA, this.lblPB, this.lblPlan, this.lblPrecio, this.btnComprar, this.nudCantBonos });
            }
        }

        private void CompraBonos_Load(object sender, EventArgs e)
        {
            
        }

        public bool cargarDatosBono(String nroAfi)
        {
            String planDesc ="";
            String precioBono="";
            bool resultado=false;
            String unaQuery = "select pla.pla_desc as Descripcion, pla.pla_precio_consulta Precio from pico_y_pala.afiliado afi join pico_y_pala.planes pla on afi.afi_pla_codigo=pla.pla_codigo where afi.afi_nro_afiliado='"+nroAfi+"'";
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand(unaQuery, cx);
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        planDesc = sqlReader["Descripcion"].ToString();
                        precioBono = sqlReader["Precio"].ToString();
                        resultado = true;
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            this.lblPlan.Text = planDesc;
            this.lblPrecio.Text = precioBono;
            return resultado;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (BuscarAfiliado buscarAfi = new BuscarAfiliado("Seleccionar"))
            {
                if (buscarAfi.ShowDialog().Equals(DialogResult.OK))
                {
                    this.afiliado = buscarAfi.AfiliadoReturn;
                    if (this.afiliado.getHabilitado())
                        this.txtNroAfi.Text = this.afiliado.getNroAfiliado();
                    else
                        MessageBox.Show("El afiliado seleccionado no se encuentra habilitado para realizar esta operacion", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (cargarDatosBono(this.txtNroAfi.Text))
            {
                ManipulacionComponentes.verComponentes(new List<Control>() { this.lblCant, this.lblPA, this.lblPB, this.lblPlan, this.lblPrecio, this.btnComprar, this.nudCantBonos });
            }
            else
            {
                MessageBox.Show("Numero de Afiliado incorrecto", "Error al Buscar Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            SqlConnection cx = null;
            try
            {
                cx = Connection.getConnection();
                cx.Open();
                SqlCommand sqlCmd = new SqlCommand("PICO_Y_PALA.compraBonos", cx);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@afi_NroAfi", SqlDbType.BigInt).Value = Int64.Parse(this.txtNroAfi.Text);
                sqlCmd.Parameters.Add("@cantBonos", SqlDbType.Int).Value = this.nudCantBonos.Value;
                sqlCmd.Parameters.Add("@precioBonos", SqlDbType.Int).Value = this.lblPrecio.Text;
                sqlCmd.Parameters.Add("@fechaSistema", SqlDbType.SmallDateTime).Value = DateTime.Parse(ConfigurationManager.AppSettings["fechaActualSistema"].ToString());
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                MessageBox.Show("Compra realizada con exito! Total: "+(this.nudCantBonos.Value*(Int32.Parse(lblPrecio.Text)))+"$");
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
