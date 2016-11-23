using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.BaseDeDatos.Componentes
{
    class ManipulacionComponentes
    {
        public static void llenarComboBox(ComboBox unCombo, String unaQuery, String campoAMostrar)
        {
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand(unaQuery, cx);
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        unCombo.Items.Add(sqlReader[campoAMostrar].ToString());
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static void llenarComboBox(ComboBox unCombo, List<String> elementos, String campoAMostrar)
        {
            try
            {
                foreach (String elemento in elementos)
                {
                    unCombo.Items.Add(elemento);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void llenarListBox(ListBox listBox, String unaQuery, String campoAMostrar)
        {
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand(unaQuery, cx);
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        listBox.Items.Add(sqlReader[campoAMostrar].ToString());
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static void vaciarListBox(ListBox listBox)
        {
            listBox.Items.Clear();
        }

        public static void llenarGrid(DataGridView dgv, String unaQuery, DataSet pagingDS, int scrollVal, int cantPorPagina, String tabla)
        {
            pagingDS.Clear();
            SqlConnection cx = Connection.getConnection();
            SqlDataAdapter pagingAdapter = new SqlDataAdapter(unaQuery, cx);
            cx.Open();
            pagingAdapter.Fill(pagingDS, scrollVal, cantPorPagina, tabla);
            cx.Close();
        }

        public static void vaciarGrid(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
        }

        public static void deshabilitarComponentes(List<Control> controles)
        {
            foreach (Control control in controles)
            {
                control.Enabled = false;
            }
        }

        public static void habilitarComponentes(List<Control> controles)
        {
            foreach (Control control in controles)
            {
                control.Enabled = true;
            }
        }

        public static void verComponentes(List<Control> controles)
        {
            foreach (Control control in controles)
            {
                control.Visible = true;
            }
        }

        public static void vaciarTextos(List<Control> controles)
        {
            foreach (Control control in controles)
            {
                control.Text = "";
            }
        }

        public static int obtenerDropDownMaxWidthCombo(ComboBox unCombo)
        {
            int maxWidth = 0, temp = 0;
            foreach (var obj in unCombo.Items)
            {
                temp = TextRenderer.MeasureText(obj.ToString(), unCombo.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            return maxWidth;
        }

    }
}
