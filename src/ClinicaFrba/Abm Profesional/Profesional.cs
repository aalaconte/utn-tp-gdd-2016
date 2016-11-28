using ClinicaFrba.Abm_Especialidades_Medicas;
using System;
using System.Collections.Generic;
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

    }
}
