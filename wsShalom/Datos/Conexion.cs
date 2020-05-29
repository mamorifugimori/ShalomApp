using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MySql.Data.MySqlClient;
using System.Configuration;

namespace wsShalom.Datos
{
    public class Conexion
    {
        string connectionString;
        MySqlConnection objConn;

        public MySqlConnection obtenerConexion()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MySQLServer"].ConnectionString;
            objConn = new MySqlConnection(connectionString);
            return objConn;
        }
    }
}