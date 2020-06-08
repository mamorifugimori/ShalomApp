namespace ShalomApp.Domain.Entidades
{
    using Datos;
    using System;
    using System.Data;

    public class MedNatural
    {
        Insertar inserciones;
        Consultar consultas;
        Modificar modificaciones;
        Eliminar eliminaciones;

        public int IdMedNatural { get; set; }
        public int IdDiagnostico { get; set; }
        public DateTime Fecha { get; set; }
        public string Tratamiento { get; set; }
        public string Observaciones { get; set; }

        public bool AgregaMedicinaNatural()
        {
            inserciones = new Insertar();
            return inserciones.AgregarMedicinaNatural(IdDiagnostico,Fecha,Tratamiento,Observaciones);
        }

        public DataSet ConsultaMedicinasNaturales()
        {
            consultas = new Consultar();
            return consultas.ObtenerMedicinasNaturales();
        }

        public DataSet ConsultaMedNaturalXDiagnostico()
        {
            consultas = new Consultar();
            return consultas.ObtenerMedNaturalXDiagnostico(IdDiagnostico);
        }

        public bool ModificaMedNatural()
        {
            modificaciones = new Modificar();
            return modificaciones.ModificarMedNatural(IdMedNatural, IdDiagnostico, Tratamiento, Observaciones);
        }

        public bool EliminaMedNatural()
        {
            eliminaciones = new Eliminar();
            return eliminaciones.EliminarMedNatural(IdMedNatural);
        }
    }
}
