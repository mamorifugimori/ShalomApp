namespace ShalomApp.Domain.Entidades
{
    using Datos;
    using System.Data;
    public class Doctor
    {
        Insertar inserciones;
        Consultar consultas;
        Modificar modificaciones;
        Eliminar eliminaciones;

        public int IdDoctor { get; set; }
        public int IdEspecialidad { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public DataSet ConsultaDoctores()
        {
            consultas = new Consultar();
            return consultas.ObtenerDoctores();
        }

        public bool AgregaDoctor()
        {
            inserciones = new Insertar();
            return inserciones.AgregarDoctor(IdDoctor, IdEspecialidad, Nombre, Apellido);
        }

        public bool ModificaDoctor()
        {
            modificaciones = new Modificar();
            return modificaciones.ModificarDoctor(IdDoctor, IdEspecialidad, Nombre, Apellido);
        }

        public bool EliminaDoctor()
        {
            eliminaciones = new Eliminar();
            return eliminaciones.EliminarDoctor(IdDoctor);
        }
    }
}
