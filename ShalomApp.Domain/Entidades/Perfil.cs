namespace ShalomApp.Domain.Entidades
{
    using Datos;
    using System.Data;

    public class Perfil
    {
        Insertar inserciones;
        Consultar consultas;
        Modificar modificaciones;
        Eliminar eliminaciones;

        public int IdPerfil { get; set; }
        public string Descripcion { get; set; }

        public DataSet ConsultaPerfiles()
        {
            consultas = new Consultar();
            return consultas.ObtenerPerfiles();
        }

        public bool AgregaPerfil()
        {
            inserciones = new Insertar();
            return inserciones.AgregarPerfil(Descripcion);
        }

        public bool ModificaPerfil()
        {
            modificaciones = new Modificar();
            return modificaciones.ModificarPerfil(IdPerfil, Descripcion);
        }

        public bool EliminaPerfil()
        {
            eliminaciones = new Eliminar();
            return eliminaciones.EliminarPerfil(IdPerfil);
        }
    }
}
