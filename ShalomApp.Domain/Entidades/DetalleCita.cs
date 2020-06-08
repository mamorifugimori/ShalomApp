namespace ShalomApp.Domain.Entidades
{
    using Datos;

    public class DetalleCita
    {
        Insertar inserciones;
        Modificar modificaciones;
        
        public int IdDetalleCita { get; set; }
        public int IdCita { get; set; }
        public int IdDoctor { get; set; }
        public int IdDiagnostico { get; set; }
        public string Sintomas { get; set; }
        public string Tratamiento { get; set; }

        public bool AgregaDetalleCita()
        {
            inserciones = new Insertar();
            return inserciones.AgregarDetalleCita(IdCita, IdDoctor, IdDiagnostico, Sintomas, Tratamiento);
        }

        public bool ModificaDetalleCita()
        {
            modificaciones = new Modificar();
            return modificaciones.ModificarDetalleCita(IdDetalleCita, IdDoctor, IdDiagnostico, Sintomas, Tratamiento);
        }
    }
}
