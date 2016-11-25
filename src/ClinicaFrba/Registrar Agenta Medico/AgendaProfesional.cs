﻿using ClinicaFrba.Abm_Especialidades_Medicas;
using ClinicaFrba.Abm_Profesional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public class AgendaProfesional
    {
        public Profesional Profesional { get; set; }
        public Especialidad Especialidad { get; set; }
        public Dia Dia { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public TimeSpan hhDesde { get; set; }
        public TimeSpan hhHasta { get; set; }

    }
}
