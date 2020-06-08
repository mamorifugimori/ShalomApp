namespace ShalomApp.Domain.Entidades
{
    using System;
    using Datos;
    using System.Data;

    public class HistMedico
    {
        Insertar inserciones;
        Consultar consultas;
        
        public int IdCita { get; set; }
        public string TipoHist { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public int IdPaciente { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }

        public DataSet ConsultaHistMedico()
        {
            consultas = new Consultar();
            return consultas.ObtenerHistMedico();
        }

        public DataSet ConsultaHistMedicoXFechas()
        {
            consultas = new Consultar();
            return consultas.ObtenerHistMedicoXFechas(FechaInicial, FechaFinal);
        }

        public DataSet ConsultaHistMedicoXId()
        {
            consultas = new Consultar();
            return consultas.ObtenerHistMedicoXId(IdCita);
        }

        public object AgregaHistMedico()
        {
            inserciones = new Insertar();
            return inserciones.AgregarHistMedico(TipoHist, Fecha, Hora, IdPaciente);
        }
    }
}
