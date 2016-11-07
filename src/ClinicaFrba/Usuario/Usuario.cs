using ClinicaFrba.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Usuario
{
    class Usuario
    {
        public int NroDoc { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String TipoDoc { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String EMail { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Sexo { get; set; }
        public Boolean Habilitado { get; set; }


        private static SqlConnection cx = null;

        public static int obtenerCantidadDeRoles(String unUsuario)
        {
            try
            {
                cx = Connection.getConnection();
                cx.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                SqlDataReader sqlReader;
                StringBuilder query = new StringBuilder();
                query.Append("select count(1) cantidadRoles from pico_y_pala.usuario us, pico_y_pala.rol_usuario rus, pico_y_pala.rol rol");
                query.Append(" where us.usu_username=@Username");
                query.Append(" and us.usu_username= rus.rus_usu_username and rus.rus_rol_id = rol.rol_id and rol_habilitado=1");
                sqlCmd.CommandText = query.ToString();
                sqlCmd.Connection = cx;
                sqlCmd.Parameters.Add(new SqlParameter("Username", unUsuario));
                sqlReader = sqlCmd.ExecuteReader();
                sqlReader.Read();

                return (int)sqlReader["cantidadRoles"];
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cx.Close();
            }
        }

        public static String obtenerPrimerRol(String unUsuario)
        {
            cx = Connection.getConnection();
            cx.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            SqlDataReader sqlReader;
            StringBuilder query = new StringBuilder();
            query.Append("select rol_nombre from pico_y_pala.usuario us, pico_y_pala.rol_usuario rus, pico_y_pala.rol rol ");
            query.Append("where us.usu_username=@Username");
            query.Append(" AND usu_username= rus.rus_usu_username AND rus.rus_rol_id = rol.rol_id");
            sqlCmd.CommandText = query.ToString();
            sqlCmd.Connection = cx;
            sqlCmd.Parameters.Add(new SqlParameter("Username", unUsuario));
            sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();

            return sqlReader["rol_nombre"].ToString();
        }

    }
}
