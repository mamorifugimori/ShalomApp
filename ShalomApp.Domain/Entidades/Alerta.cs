namespace ShalomApp.Domain.Entidades
{
    using Datos;
    using System.Data;
    public class Alerta
    {
        Insertar inserciones;
        Modificar modificaciones;
        Consultar consultas;

        public int IdAlerta { get; set; }
        public int IdCita { get; set; }
        public int IdParamedico { get; set; }
        public int IdDiagnostico { get; set; }
        public string Sintomas { get; set; }
        public string Tratamiento { get; set; }
        public string Estado { get; set; }
        public int UPaciente { get; set; }
        public int UParamedico { get; set; }

        public bool AgregaAlerta()
        {
            inserciones = new Insertar();
            return inserciones.AgregarAlerta(IdCita, Sintomas, Tratamiento, UPaciente);
        }

        public DataSet ConsultaAlertasPendientes()
        {
            consultas = new Consultar();
            return consultas.ObtenerAlertasPendientes();
        }

        public DataSet ConsultaAlertasXParamedico()
        {
            consultas = new Consultar();
            return consultas.ObtenerAlertasXParamedico(IdParamedico);
        }

        public DataSet ConsultaAlertaXId()
        {
            consultas = new Consultar();
            return consultas.ObtenerAlertaXId(IdAlerta);
        }

        public bool ModificaAlertaAtendido()
        {
            modificaciones = new Modificar();
            return modificaciones.ModificarAlertaAtendido(IdAlerta, Sintomas, Tratamiento);
        }

        public bool ModificaAlertaEnCurso()
        {
            modificaciones = new Modificar();
            return modificaciones.ModificarAlertaEnCurso(IdAlerta, IdParamedico, UParamedico);
        }

        public bool ModificaAlertaUParamedico()
        {
            modificaciones = new Modificar();
            return modificaciones.ModificarAlertaUParamedico(IdAlerta, UParamedico);
        }
    }
}
