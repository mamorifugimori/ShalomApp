namespace ShalomApp.Domain.Datos
{
    using MySql.Data.MySqlClient;

    class Conexion
    {
        string connectionString;
        MySqlConnection objConn;

        public MySqlConnection ObtenerConexion()
        {
            connectionString = "Server=localhost;Database=shalomdb;uid=shalomApp;pwd=mamori";
            objConn = new MySqlConnection(connectionString);
            return objConn;
        }
    }
}