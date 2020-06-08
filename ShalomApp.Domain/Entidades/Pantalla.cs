namespace ShalomApp.Domain.Entidades
{
    using Datos;
    using System.Data;

    public class Pantalla
    {
        Insertar inserciones;
        Consultar consultas;
        Modificar modificaciones;
        Eliminar eliminaciones;

        public int IdPantalla { get; set; }
        public int IdPerfil { get; set; }
        public string NombrePantalla { get; set; }

        public DataSet ConsultaPantallas()
        {
            consultas = new Consultar();
            return consultas.ObtenerPantallas();
        }

        public DataSet ConsultaPantallaXPerfil()
        {
            consultas = new Consultar();
            return consultas.ObtenerPantallaXPerfil(IdPerfil);
        }

        public bool AgregaPantalla()
        {
            inserciones = new Insertar();
            return inserciones.AgregarPantalla(IdPerfil, NombrePantalla);
        }

        public bool ModificaPantalla()
        {
            modificaciones = new Modificar();
            return modificaciones.ModificarPantalla(IdPantalla, IdPerfil, NombrePantalla);
        }

        public bool EliminaPantalla()
        {
            eliminaciones = new Eliminar();
            return eliminaciones.EliminarPantalla(IdPantalla);
        }
    }
}
