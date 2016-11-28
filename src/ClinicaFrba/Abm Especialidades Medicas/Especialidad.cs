using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Abm_Especialidades_Medicas
{
    public class Especialidad
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }
        public TipoEspecialidad TipoEspecialidad { get; set; }

        public Especialidad() { }

        public Especialidad(int unId, String unaDescripcion)
        {
            Id = unId;
            Descripcion = unaDescripcion;

        }

        public Especialidad(int unId)
        {
            Id = unId;
        }

    }
}
