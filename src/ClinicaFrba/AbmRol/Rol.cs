using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.AbmRol
{
    public class Rol
    {
        public Rol() { }
        public Rol(int unId, String unNombre, bool habilitacion)
        {
            this.id = unId;
            this.habilitado = habilitacion;
            this.nombre = unNombre;
        }
        private int id;
        private bool habilitado;
        private String nombre;

        public int getId()
        {
            return this.id;
        }

        public void setId(int unId)
        {
            this.id = unId;
        }

        public bool getHabilitado()
        {
            return this.habilitado;
        }

        public void setHabilitado(bool unaHabilitacion)
        {
            this.habilitado = unaHabilitacion;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setNombre(String unNombre)
        {
            this.nombre = unNombre;
        }

        public String toString()
        {
            return this.id + this.nombre + this.habilitado;
        }
    }
}
