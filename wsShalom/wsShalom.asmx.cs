namespace wsShalom
{
    using System.Web.Services;

    using System.Data;
    using ShalomApp.Domain.Entidades;


    /// <summary>
    /// Descripción breve de wsShalom
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsShalom : System.Web.Services.WebService
    {
        Especialidad especialidad;
        Doctor doctor;

        [WebMethod]
        public DataSet ConsultaEspecialidad()
        {
            especialidad = new Especialidad();
            return especialidad.ConsultaEspecialidades();
        }

        [WebMethod]
        public string AgregaEspecialidad(string prEspecialidad)
        {
            especialidad = new Especialidad
            {
                Descripcion = prEspecialidad
            };

            if (especialidad.AgregaEspecialidad())
                return "agregado correctamente";
            else
                return "algo salió mal en la inserción";
        }

        [WebMethod]
        public DataSet ConsultaDoctor()
        {
            doctor = new Doctor();
            return doctor.ConsultaDoctores();
        }
    }
}
