namespace ShalomApp.Domain.Datos
{
    using MySql.Data.MySqlClient;
    using System;

    class Modificar
    {
        readonly Conexion conexion;
        MySqlConnection objConn;
        public Modificar()
        {
            conexion = new Conexion();
        }

        public bool ModificarDiagnostico(int idDiagnostico, string descripcion)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("update diagnostico set descripcion = @descripcion where iddiagnostico = @iddiagnostico")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@descripcion", descripcion);
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

        public bool ModificarMedNatural(int idMedNatural, int idDiagnostico, string tratamiento, string observaciones)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("update mednatural set iddiagnostico = @iddiagnostico, tratamiento = @tratamiento, observaciones = @observaciones where idmednatural = @idmednatural")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@iddiagnostico", idDiagnostico);
            comando.Parameters.AddWithValue("@tratamiento", tratamiento);
            comando.Parameters.AddWithValue("@observaciones", observaciones);
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

        public bool ModificarEspecialidad(int idEspecialidad, string descripcion)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("update especialidad set descripcion = @descripcion where idespecialidad = @idespecialidad")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@idespecialidad", idEspecialidad);
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

        public bool ModificarDoctor(int idDoctor, int idEspecialidad, string nombre, string apellido)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("update doctor set idespecialidad = @idespecialidad, nombre = @nombre, apellido = @apellido where iddoctor = @iddoctor")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idespecialidad", idEspecialidad);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
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

        public bool ModificarParamedico(int idParamedico, string documento, string nombre, string apellido, string nivelExpertise)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("update paramedico set documento = @documento, nombre = @nombre, apellido = @apellido, nivelexpertise = @nivelExpertise where idparamedico = @idparamedico")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@nivelExpertise", nivelExpertise);
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

        public bool ModificarPerfil(int idPerfil, string descripcion)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("update perfil set descripcion = @descripcion where idperfil = @idperfil")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@descripcion", descripcion);
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

        public bool ModificarPantalla(int idPantalla, int idPerfil, string nombrePantalla)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("update pantalla set idperfil = @idperfil, pantalla = @pantalla where idpantalla = @idpantalla")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idperfil", idPerfil);
            comando.Parameters.AddWithValue("@pantalla", nombrePantalla);
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

        public bool ModificarLogin(int idLogin, int idPerfil, string alias, string password, int idParamedico, int idDoctor, int idPaciente)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("update login set idperfil = @idperfil, alias = @alias, password = @password, idpaciente = case @idpaciente when 0 then null else @idpaciente end, iddoctor = case @iddoctor when 0 then null else @iddoctor end, idparamedico = case @idparamedico when 0 then null else @idparamedico end where idlogin = @idlogin")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idperfil", idPerfil);
            comando.Parameters.AddWithValue("@alias", alias);
            comando.Parameters.AddWithValue("@password", password);
            comando.Parameters.AddWithValue("@iddoctor", idDoctor);
            comando.Parameters.AddWithValue("@idpaciente", idPaciente);
            comando.Parameters.AddWithValue("@idparamedico", idParamedico);
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

        public bool ModificarPaciente(int idPaciente, string documento, string nombre, string apellido, DateTime fechaNacimiento)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("update paciente set documento = @documento, nombre = @nombre, apellido = @apellido, fechanacimiento = @fechanacimiento where idpaciente = @idpaciente")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@fechanacimiento", fechaNacimiento.ToString("yyyy-MM-dd"));
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

        public bool ModificarPacienteMenor(int idPaciente, string nombre, string apellido, DateTime fechaNacimiento, int idResponsable)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("update paciente set nombre = @nombre, apellido = @apellido, fechanacimiento = @fechanacimiento, idresponsable = @idresponsable where idpaciente = @idpaciente")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@fechanacimiento", fechaNacimiento.ToString("yyyy-MM-dd"));
            comando.Parameters.AddWithValue("@idresponsable", idResponsable);
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

        public bool ModificarDetalleCita(int idDetalleCita, int idDoctor, int idDiagnostico, string sintomas, string tratamiento)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("update detallecita set iddoctor = @iddoctor, iddiagnostico = @iddiagnostico, sintomas = @sintomas, tratamiento = @tratamiento where iddetallecita = @iddetallecita")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@iddoctor", idDoctor);
            comando.Parameters.AddWithValue("@iddiagnostico", idDiagnostico);
            comando.Parameters.AddWithValue("@sintomas", sintomas);
            comando.Parameters.AddWithValue("@tratamiento", tratamiento);
            comando.Parameters.AddWithValue("@iddetallecita", idDetalleCita);
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

        public bool ModificarAlertaAtendido(int idAlerta, string sintomas, string tratamiento)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("update alerta set sintomas = @sintomas, tratamiento = @tratamiento, estado = 'ATENDIDO' where idalerta = @idalerta")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@sintomas", sintomas);
            comando.Parameters.AddWithValue("@tratamiento", tratamiento);
            comando.Parameters.AddWithValue("@idalerta", idAlerta);
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

        public bool ModificarAlertaEnCurso(int idAlerta, int idParamedico, int uParamedico)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("update alerta set idparamedico = @idparamedico, uparamedico = @uparamedico, estado = 'EN CURSO' where idalerta = @idalerta")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idparamedico", idParamedico);
            comando.Parameters.AddWithValue("@uparamedico", uParamedico);
            comando.Parameters.AddWithValue("@idalerta", idAlerta);
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

        public bool ModificarAlertaUParamedico(int idAlerta, int uParamedico)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("update alerta set uparamedico = @uparamedico where idalerta = @idalerta")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@uparamedico", uParamedico);
            comando.Parameters.AddWithValue("@idalerta", idAlerta);
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
