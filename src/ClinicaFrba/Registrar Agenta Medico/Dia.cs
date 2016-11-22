using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public class Dia
    {
        public int Id { get; set; }
        public String Nombre { get; set; }

        public Dia(int unId, String unNombre)
        {
            this.Id = unId;
            this.Nombre = unNombre;
        }
    }
}
