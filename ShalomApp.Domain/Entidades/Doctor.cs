namespace ShalomApp.Domain.Entidades
{
    using Datos;
    using System.Data;
    public class Doctor
    {
        Consultar consultas;
        public int IdDoctor { get; set; }
        public int IdEspecialidad { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public DataSet ConsultaDoctores()
        {
            consultas = new Consultar();
            return consultas.ObtenerDoctores();
        }
    }
}
