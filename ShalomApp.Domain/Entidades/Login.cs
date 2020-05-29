using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShalomApp.Domain.Entidades
{
    class Login
    {
        public int IdLogin { get; set; }
        public string Alias { get; set; }
        public string Pasword { get; set; }
        public int IdPerfil { get; set; }
        public int IdParamedico { get; set; }
        public int IdDoctor { get; set; }
        public int IdPaciente { get; set; }
    }
}
