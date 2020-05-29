using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShalomApp.Domain.Entidades
{
    class MedNatural
    {
        public int IdMedNatural { get; set; }
        public int IdDiagnostico { get; set; }
        public DateTime Fecha { get; set; }
        public string Tratamiento { get; set; }
        public string Observaciones { get; set; }
    }
}
