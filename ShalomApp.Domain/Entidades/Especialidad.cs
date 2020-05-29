namespace ShalomApp.Domain.Entidades
{
    using Datos;
    using System.Data;

    public class Especialidad
    {
        Consultar consultas;
        Insertar inserciones;
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
    }
}
