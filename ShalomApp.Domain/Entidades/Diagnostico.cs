namespace ShalomApp.Domain.Entidades
{
    using Datos;
    using System.Data;
    public class Diagnostico
    {
        Insertar inserciones;
        Consultar consultas;
        Modificar modificaciones;
        Eliminar eliminaciones;

        public int IdDiagnostico { get; set; }
        public string Descripcion { get; set; }

        public bool AgregaDiagnostico()
        {
            inserciones = new Insertar();
            return inserciones.AgregarDiagnostico(Descripcion);
        }

        public DataSet ConsultaDiagnosticos()
        {
            consultas = new Consultar();
            return consultas.ObtenerDiagnosticos();
        }

        public bool ModificaDiagnostico()
        {
            modificaciones = new Modificar();
            return modificaciones.ModificarDiagnostico(IdDiagnostico, Descripcion);
        }

        public bool EliminaDiagnostico()
        {
            eliminaciones = new Eliminar();
            return eliminaciones.EliminarDiagnostico(IdDiagnostico);
        }
    }
}
