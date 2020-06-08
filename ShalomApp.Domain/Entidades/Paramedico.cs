namespace ShalomApp.Domain.Entidades
{
    using Datos;
    using System;
    using System.Data;

    public class Paramedico
    {
        Insertar inserciones;
        Consultar consultas;
        Modificar modificaciones;
        Eliminar eliminaciones;

        public int IdParamedico { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string NivelExpertise { get; set; }

        public DataSet ConsultaParamedicos()
        {
            consultas = new Consultar();
            return consultas.ObtenerParamedicos();
        }

        public bool AgregaParamedico()
        {
            inserciones = new Insertar();
            return inserciones.AgregarParamedico(Documento, Nombre, Apellido, FechaIngreso, NivelExpertise);
        }

        public bool ModificaParamedico()
        {
            modificaciones = new Modificar();
            return modificaciones.ModificarParamedico(IdParamedico, Documento, Nombre, Apellido, NivelExpertise);
        }

        public bool EliminaParamedico()
        {
            eliminaciones = new Eliminar();
            return eliminaciones.EliminarParamedico(IdParamedico);
        }
    }
}
