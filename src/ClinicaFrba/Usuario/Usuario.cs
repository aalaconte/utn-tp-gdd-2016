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
                query.Append("select count(1) cantidadRoles from VAROLATTO.usuario, VAROLATTO.rol_usuario, VAROLATTO.rol");
                query.Append(" where usu_username=@Username");
                query.Append(" and usu_username=rus_usuario and rus_rol = rol_id and rol_habilitado=1");
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
            query.Append("select rol_nombre from VAROLATTO.usuario, VAROLATTO.rol_usuario, VAROLATTO.rol");
            query.Append(" where usu_username=@Username");
            query.Append(" and usu_username=rus_usuario and rus_rol = rol_id");
            sqlCmd.CommandText = query.ToString();
            sqlCmd.Connection = cx;
            sqlCmd.Parameters.Add(new SqlParameter("Username", unUsuario));
            sqlReader = sqlCmd.ExecuteReader();
            sqlReader.Read();

            return sqlReader["rol_nombre"].ToString();
        }

    }
}
