namespace ShalomApp.Domain.Entidades
{
    using System;

    public class MedNatural
    {
        public int IdMedNatural { get; set; }
        public int IdDiagnostico { get; set; }
        public DateTime Fecha { get; set; }
        public string Tratamiento { get; set; }
        public string Observaciones { get; set; }
    }
}
