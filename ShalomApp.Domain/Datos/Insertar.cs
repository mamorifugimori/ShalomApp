namespace ShalomApp.Domain.Datos
{
    using MySql.Data.MySqlClient;
    using System;

    class Insertar
    {
        Conexion conexion;
        MySqlConnection objConn;
        public Insertar()
        {
            conexion = new Conexion();
        }

        public bool AgregarEspecialidad(string descripcion)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("insert into especialidad(descripcion) values ('{0}')", descripcion))
            {
                Connection = objConn
            };
            try
            {
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
                return true;
            }
            catch (MySqlException)
            {
                comando.Connection.Close();
                return false;
            }
            
        }
    }
}