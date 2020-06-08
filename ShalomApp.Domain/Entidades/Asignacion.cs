namespace ShalomApp.Domain.Entidades
{
    using Datos;
    using System.Data;

    public class Asignacion
    {
        Insertar inserciones;
        Eliminar eliminaciones;
        Consultar consultas;

        public int IdDoctor { get; set; }
        public int IdPaciente { get; set; }

        public DataSet ConsultaAsignaciones()
        {
            consultas = new Consultar();
            return consultas.ObtenerAsignaciones();
        }

        public DataSet ConsultaAsignacion()
        {
            consultas = new Consultar();
            return consultas.ObtenerAsignacion(IdPaciente, IdDoctor);
        }

        public bool AgregaAsignacion()
        {
            inserciones = new Insertar();
            return inserciones.AgregarAsignacion(IdPaciente, IdDoctor);
        }

        public bool EliminaAsignacion()
        {
            eliminaciones = new Eliminar();
            return eliminaciones.EliminarAsignacion(IdPaciente, IdDoctor);
        }
    }
}
