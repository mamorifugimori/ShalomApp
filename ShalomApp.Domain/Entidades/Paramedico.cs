namespace ShalomApp.Domain.Entidades
{
    using System;

    public class Paramedico
    {
        public int IdParamedico { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string NivelExpertise { get; set; }
    }
}
