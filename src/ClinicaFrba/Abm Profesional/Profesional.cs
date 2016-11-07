using ClinicaFrba.Abm_Especialidades_Medicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Abm_Profesional
{
    class Profesional : Usuario.Usuario
    {
        public int Matricula { get; set; }
        public List<Especialidad> Especialidades { get; set; }

    }
}
