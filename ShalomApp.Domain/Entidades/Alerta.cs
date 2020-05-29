using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShalomApp.Domain.Entidades
{
    class Alerta
    {
        public int IdAlerta { get; set; }
        public int IdCita { get; set; }
        public int IdParamedico { get; set; }
        public int IdDiagnostico { get; set; }
        public string Sintomas { get; set; }
        public string Tratamiento { get; set; }
        public string Estado { get; set; }
        public int UPaciente { get; set; }
        public int UParamedico { get; set; }
    }
}
