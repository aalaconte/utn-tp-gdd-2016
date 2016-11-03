using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Abm_Afiliado
{
    class Afiliado
    {
        public Afiliado() { }
        public Afiliado(int unId, String unNombre, String unApellido)
        {
            this.iDAfiliado = unId;
            this.apellido = unApellido;
            this.nombre = unNombre;
        }
        private int iDAfiliado;
        private String username;
        private String password;
        private String nombre;
        private String apellido;
        private String direccion;
        private String telefono;
        private String mail;
        private String fechaNac;
        private char sexo;
        private String estadoCivil;
        private String cantHijosFam;
        private String plan;
        private int nroAfiliado;
        private bool habilitado;



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

    }
}
