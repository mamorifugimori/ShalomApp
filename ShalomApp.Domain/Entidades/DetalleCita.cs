using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShalomApp.Domain.Entidades
{
    class DetalleCita
    {
        public int IdDetalleCita { get; set; }
        public int IdCita { get; set; }
        public int IdDoctor { get; set; }
        public int IdDiagnostico { get; set; }
        public string Sintomas { get; set; }
        public string Tratamiento { get; set; }
    }
}
