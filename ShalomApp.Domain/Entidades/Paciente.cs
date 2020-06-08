namespace ShalomApp.Domain.Entidades
{
    using Datos;
    using System;
    using System.Data;

    public class Paciente
    {
        Insertar inserciones;
        Consultar consultas;
        Modificar modificaciones;
        Eliminar eliminaciones;

        public int IdPaciente { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int IdResponsable { get; set; }

        public DataSet ConsultaPacientes()
        {
            consultas = new Consultar();
            return consultas.ObtenerPacientes();
        }

        public DataSet ConsultaPacienteXDPI()
        {
            consultas = new Consultar();
            return consultas.ObtenerPacienteXDPI(Documento);
        }

        public DataSet ConsultaPacienteXId()
        {
            consultas = new Consultar();
            return consultas.ObtenerPacienteXId(IdPaciente);
        }

        public DataSet ConsultaPacienteXNombre()
        {
            consultas = new Consultar();
            return consultas.ObtenerPacienteXNombre(Nombre, Apellido);
        }

        public bool AgregaPaciente()
        {
            inserciones = new Insertar();
            return inserciones.AgregarPaciente(Documento, Nombre, Apellido, FechaNacimiento, FechaIngreso);
        }

        public bool AgregaPacienteMenor()
        {
            inserciones = new Insertar();
            return inserciones.AgregarPacienteMenor(Nombre, Apellido, FechaNacimiento, FechaIngreso, IdResponsable);
        }

        public bool ModificaPaciente()
        {
            modificaciones = new Modificar();
            return modificaciones.ModificarPaciente(IdPaciente, Documento, Nombre, Apellido, FechaNacimiento);
        }

        public bool ModificaPacienteMenor()
        {
            modificaciones = new Modificar();
            return modificaciones.ModificarPacienteMenor(IdPaciente, Nombre, Apellido, FechaNacimiento, IdResponsable);
        }

        public bool EliminaPaciente()
        {
            eliminaciones = new Eliminar();
            return eliminaciones.EliminarPaciente(IdPaciente);
        }
    }
}
