using ClinicaFrba.Abm_Especialidades_Medicas;
using ClinicaFrba.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Abm_Profesional
{
    public class Profesional : Usuario.Usuario
    {

        public int Matricula { get; set; }
        public List<Especialidad> Especialidades { get; set; }

        public Profesional() { }

        public Profesional(int unNroDoc)
        {
            this.NroDoc = unNroDoc;
        }

        public Profesional(String unApellido, String unNombre, String unTipoDoc, int unNroDoc, int unaMatricula)
        {
            this.Apellido = unApellido;
            this.Nombre = unNombre;
            this.TipoDoc = unTipoDoc;
            this.NroDoc = unNroDoc;
            this.Matricula = unaMatricula;
        }

        public Profesional(String unApellido, String unNombre)
        {
            this.Apellido = unApellido;
            this.Nombre = unNombre;
        }

        public static long buscarNroProPorUser(String username)
        {
            long docPro = 0;
            String unaQuery = "select pro.pro_nro_doc as ProDoc from pico_y_pala.profesional pro join pico_y_pala.usuario usu on pro.pro_nro_doc=usu.usu_nro_doc where usu.usu_username='" + username + "'";
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand(unaQuery, cx);
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        docPro = Int64.Parse(sqlReader["ProDoc"].ToString());
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return docPro;
        }

    }
}
