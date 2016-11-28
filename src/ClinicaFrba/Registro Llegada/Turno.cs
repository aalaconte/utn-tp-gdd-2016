using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Registro_Llegada
{
    public class Turno
    {
        public string idTurno { get; set; }
        public string fechaTurno { get; set; }

        public Turno(string unId,string unaFecha)
        {
            this.idTurno = unId;
            this.fechaTurno = unaFecha;
        }


    }
}
