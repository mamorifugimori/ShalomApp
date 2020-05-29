using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShalomApp.Domain.Entidades
{
    class Doctor
    {
        public int IdDoctor { get; set; }
        public int IdEspecialidad { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
