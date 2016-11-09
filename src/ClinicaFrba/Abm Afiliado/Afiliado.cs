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
        public Afiliado(String unUsername, String unaPassword, String unNombre, String unApellido, String unaDireccion, int unTelefono, String unMail, String unaFechaNac, char unSexo, String unEstadoCivil, int unaCantHijosFam, String unPlan)
        {
            this.username = unUsername;
            this.password = unaPassword;
            this.apellido = unApellido;
            this.nombre = unNombre;
            this.direccion = unaDireccion;
            this.telefono = unTelefono;
            this.mail = unMail;
            this.fechaNac = unaFechaNac;
            this.cantHijosFam = unaCantHijosFam;
            this.estadoCivil = unEstadoCivil;
            this.plan = unPlan;
            this.sexo = unSexo;
            this.habilitado = true;
        }
        private int iDAfiliado;
        private String username;
        private String password;
        private String nombre;
        private String apellido;
        private String direccion;
        private int telefono;
        private String mail;
        private String fechaNac;
        private char sexo;
        private String estadoCivil;
        private int cantHijosFam;
        private String plan;
        private int nroAfiliado;
        private bool habilitado;

        public bool getHabilitado()
        {
            return this.habilitado;
        }

        public void setHabilitado(bool estado)
        {
            this.habilitado = estado;
        }

        public int getNroAfiliado()
        {
            return this.nroAfiliado;
        }

        public void setNroAfiliado(int unNroAfiliado)
        {
            this.nroAfiliado = unNroAfiliado;
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

        public char getSexo()
        {
            return this.sexo;
        }

        public void setSexo(char unSexo)
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

        public int getTelefono()
        {
            return this.telefono;
        }

        public void setDireccion(int unTel)
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

    }
}
