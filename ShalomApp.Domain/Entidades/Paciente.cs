namespace ShalomApp.Domain.Entidades
{
    using System;

    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int IdResponsable { get; set; }
    }
}
