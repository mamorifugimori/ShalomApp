using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShalomApp.Domain.Entidades
{
    class HistMedico
    {
        public int IdCita { get; set; }
        public string TipoHist { get; set; }
        public DateTime Fecha { get; set; }
        public int Hora { get; set; }
        public int IdPaciente { get; set; }
    }
}
