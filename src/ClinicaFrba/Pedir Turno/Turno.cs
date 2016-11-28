using ClinicaFrba.Abm_Afiliado;
using ClinicaFrba.Abm_Especialidades_Medicas;
using ClinicaFrba.Abm_Profesional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Pedir_Turno
{
    public class Turno
    {
        public int Id { get; set; }
        public Afiliado Afiliado { get; set; }
        public Profesional Profesional { get; set; }
        public Especialidad Especialidad { get; set; }
        public DateTime FechaHora { get; set; }

        public Turno() { }

        public Turno(DateTime unaFechaHora)
        {
            this.FechaHora = unaFechaHora;
        }

    }
}
