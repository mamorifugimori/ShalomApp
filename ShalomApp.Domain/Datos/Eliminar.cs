namespace ShalomApp.Domain.Datos
{
    using MySql.Data.MySqlClient;
    class Eliminar
    {
        readonly Conexion conexion;
        MySqlConnection objConn;
        public Eliminar()
        {
            conexion = new Conexion();
        }

        public bool EliminarDiagnostico(int idDiagnostico)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("delete from diagnostico where iddiagnostico = @iddiagnostico")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@iddiagnostico", idDiagnostico);
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

        public bool EliminarEspecialidad(int idEsepecialidad)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("delete from especialidad where idespecialidad = @idespecialidad")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idespecialidad", idEsepecialidad);
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

        public bool EliminarMedNatural(int idMedNatural)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("delete from mednatural where idmednatural = @idmednatural")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idmednatural", idMedNatural);
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

        public bool EliminarDoctor(int idDoctor)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("delete from doctor where iddoctor = @iddoctor")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@iddoctor", idDoctor);
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

        public bool EliminarParamedico(int idParamedico)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("delete from paramedico where idparamedico = @idparamedico")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idparamedico", idParamedico);
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

        public bool EliminarPerfil(int idPerfil)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("delete from perfil where idperfil = @idperfil")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idperfil", idPerfil);
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

        public bool EliminarPantalla(int idPantalla)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("delete from pantalla where idpantalla = @idpantalla")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idpantalla", idPantalla);
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

        public bool EliminarLogin(int idLogin)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("delete from login where idlogin = @idlogin")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idlogin", idLogin);
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

        public bool EliminarPaciente(int idPaciente)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("delete from paciente where idpaciente = @idpaciente")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idpaciente", idPaciente);
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

        public bool EliminarAsignacion(int idPaciente, int idDoctor)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("delete from asignacion where idpaciente = @idpaciente and iddoctor = @iddoctor")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idpaciente", idPaciente);
            comando.Parameters.AddWithValue("@iddoctor", idDoctor);
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
