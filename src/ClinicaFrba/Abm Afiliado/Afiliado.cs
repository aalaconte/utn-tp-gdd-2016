using ClinicaFrba.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Abm_Afiliado
{
    public class Afiliado
    {
        public Afiliado() { }
        public Afiliado(String unUsername, String unNroAfi, String unNombre, String unApellido,String unDoc, String unaDireccion, String unTelefono, String unMail, String unaFechaNac, String unPlan, bool unHabilitado)
        {
            this.username = unUsername;
            this.nroAfiliado = unNroAfi;
            this.apellido = unApellido;
            this.nombre = unNombre;
            this.direccion = unaDireccion;
            this.telefono = unTelefono;
            this.mail = unMail;
            this.fechaNac = unaFechaNac;
            this.plan = unPlan;
            this.documento = unDoc;
            this.habilitado = unHabilitado;
        }
        private int iDAfiliado;
        private String documento;
        private String username;
        private String password;
        private String nombre;
        private String apellido;
        private String direccion;
        private String telefono;
        private String mail;
        private String fechaNac;
        private String sexo;
        private String estadoCivil;
        private String plan;
        private String nroAfiliado;
        private bool habilitado;

        public bool getHabilitado()
        {
            return this.habilitado;
        }

        public void setHabilitado(bool estado)
        {
            this.habilitado = estado;
        }

        public String getNroAfiliado()
        {
            return this.nroAfiliado;
        }

        public void setNroAfiliado(String unNroAfiliado)
        {
            this.nroAfiliado = unNroAfiliado;
        }

        public String getDocumento()
        {
            return this.documento;
        }

        public void setDocumento(String unDoc)
        {
            this.documento = unDoc;
        }

        public String getPlan()
        {
            return this.plan;
        }

        public void setPlan(String unPlan)
        {
            this.plan = unPlan;
        }

        public String getEstadoCivil()
        {
            return this.estadoCivil;
        }

        public void setEstadoCivil(String unEstadoCivil)
        {
            this.estadoCivil = unEstadoCivil;
        }

        public String getSexo()
        {
            return this.sexo;
        }

        public void setSexo(String unSexo)
        {
            this.sexo = unSexo;
        }

        public String getFechaNac()
        {
            return this.fechaNac;
        }

        public void setFechaNac(String unafechaNac)
        {
            this.fechaNac = unafechaNac;
        }


        public String getMail()
        {
            return this.mail;
        }

        public void setMail(String unMail)
        {
            this.mail = unMail;
        }

        public String getTelefono()
        {
            return this.telefono;
        }

        public void setTelefono(String unTel)
        {
            this.telefono = unTel;
        }

        public String getDireccion()
        {
            return this.direccion;
        }

        public void setDireccion(String unaDirec)
        {
            this.direccion = unaDirec;
        }

        public String getPassword()
        {
            return this.password;
        }

        public void setPassword(String unaPass)
        {
            this.password = unaPass;
        }

        public String getUsername()
        {
            return this.username;
        }

        public void setUsername(String unUsername)
        {
            this.username = unUsername;
        }

        public int getId()
        {
            return this.iDAfiliado;
        }

        public void setId(int unId)
        {
            this.iDAfiliado = unId;
        }

        public String getApellido()
        {
            return this.apellido;
        }

        public void setApellido(String unApellido)
        {
            this.apellido = unApellido;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setNombre(String unNombre)
        {
            this.nombre = unNombre;
        }

        public static long buscarNroAfiporUser(String username)
        {
            long numeroAfi = 0;
            String unaQuery = "select afi_nro_afiliado as NroAfiliado from pico_y_pala.afiliado afi join pico_y_pala.usuario usu on afi.afi_nro_doc=usu.usu_nro_doc where usu.usu_username='"+username+"'";
            using (SqlConnection cx = Connection.getConnection())
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand(unaQuery, cx);
                    cx.Open();
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        numeroAfi = Int64.Parse(sqlReader["NroAfiliado"].ToString());
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return numeroAfi;
        }


    }
}
