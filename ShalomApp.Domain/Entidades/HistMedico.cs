namespace ShalomApp.Domain.Entidades
{
    using System;

    public class HistMedico
    {
        public int IdCita { get; set; }
        public string TipoHist { get; set; }
        public DateTime Fecha { get; set; }
        public int Hora { get; set; }
        public int IdPaciente { get; set; }
    }
}
