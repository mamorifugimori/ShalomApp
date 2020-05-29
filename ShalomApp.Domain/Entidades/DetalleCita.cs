namespace ShalomApp.Domain.Entidades
{
    public class DetalleCita
    {
        public int IdDetalleCita { get; set; }
        public int IdCita { get; set; }
        public int IdDoctor { get; set; }
        public int IdDiagnostico { get; set; }
        public string Sintomas { get; set; }
        public string Tratamiento { get; set; }
    }
}
