using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using wsShalom.Datos;

using System.Data;

namespace wsShalom
{
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
        Consultar consultas;

        [WebMethod]
        public DataSet ConsultaEspecialidad()
        {
            consultas = new Consultar();
            return consultas.obtenerEspecialidades();
        }

        [WebMethod]
        public DataSet ConsultaDoctor()
        {
            consultas = new Consultar();
            return consultas.obtenerDoctores();
        }
    }
}
