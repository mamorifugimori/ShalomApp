namespace ShalomApp.Domain.Entidades
{
    using Datos;
    using System.Data;

    public class Especialidad
    {
        Insertar inserciones;
        Consultar consultas;
        Modificar modificaciones;
        Eliminar eliminaciones;

        public int IdEspecialidad { get; set; }
        public string Descripcion { get; set; }

        public DataSet ConsultaEspecialidades()
        {
            consultas = new Consultar();
            return consultas.ObtenerEspecialidades();
        }

        public bool AgregaEspecialidad()
        {
            inserciones = new Insertar();
            return inserciones.AgregarEspecialidad(Descripcion);
        }

        public bool ModificaEspecialidad()
        {
            modificaciones = new Modificar();
            return modificaciones.ModificarEspecialidad(IdEspecialidad, Descripcion);
        }

        public bool EliminaEspecialidad()
        {
            eliminaciones = new Eliminar();
            return eliminaciones.EliminarEspecialidad(IdEspecialidad);
        }
    }
}
