﻿namespace ShalomApp.Domain.Datos
{
    using MySql.Data.MySqlClient;
    using System;

    class Insertar
    {
        readonly Conexion conexion;
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

        public bool AgregarMedicinaNatural(int idDiagnostico, DateTime fecha, string tratamiento, string observaciones)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("insert into mednatural(iddiagnostico, fecha, tratamiento, observaciones) values ({0},'{1}','{2}','{3}')", idDiagnostico,fecha.ToString("yyyy-MM-dd"),tratamiento,observaciones))
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

        public bool AgregarDiagnostico(string descripcion)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("insert into diagnostico(descripcion) values ('{0}')", descripcion))
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

        public bool AgregarDoctor(int idDoctor, int idEspecialidad, string nombre, string apellido)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("insert into doctor(iddoctor, idespecialidad, nombre, apellido) values ({0},{1},'{2}','{3}')", idDoctor, idEspecialidad, nombre, apellido))
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

        public bool AgregarParamedico(string documento, string nombre, string apellido, DateTime fecha, string nivelExpertise)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("insert into paramedico(documento, nombre, apellido, fechaingreso, nivelexpertise) values (@documento,@nombre,@apellido,@fechaingreso,@nivelExpertise)")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@fechaingreso", fecha.ToString("yyyy-MM-dd"));
            comando.Parameters.AddWithValue("@nivelExpertise", nivelExpertise);
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

        public bool AgregarPerfil(string descripcion)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("insert into perfil(descripcion) values (@descripcion)")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@descripcion", descripcion);
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

        public bool AgregarPantalla(int idPerfil, string nombrePantalla)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("insert into pantalla(idperfil, pantalla) values (@idperfil, @pantalla)")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idperfil", idPerfil);
            comando.Parameters.AddWithValue("@pantalla", nombrePantalla);
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

        public bool AgregarLoginPaciente(int idPerfil, string alias, string password, int idPaciente)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("insert into login(idperfil, alias, password, idpaciente) values (@idperfil, @alias, @password, @idpaciente)")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idperfil", idPerfil);
            comando.Parameters.AddWithValue("@alias", alias);
            comando.Parameters.AddWithValue("@password", password);
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

        public bool AgregarLoginParamedico(int idPerfil, string alias, string password, int idParamedico)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("insert into login(idperfil, alias, password, idparamedico) values (@idperfil, @alias, @password, @idparamedico)")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idperfil", idPerfil);
            comando.Parameters.AddWithValue("@alias", alias);
            comando.Parameters.AddWithValue("@password", password);
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

        public bool AgregarLoginDoctor(int idPerfil, string alias, string password, int idDoctor)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("insert into login(idperfil, alias, password, iddoctor) values (@idperfil, @alias, @password, @iddoctor)")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idperfil", idPerfil);
            comando.Parameters.AddWithValue("@alias", alias);
            comando.Parameters.AddWithValue("@password", password);
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

        public bool AgregarPaciente(string documento, string nombre, string apellido, DateTime fechaNacimiento, DateTime fechaIngreso)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("insert into paciente(documento, nombre, apellido, fechanacimiento, fechaingreso) values (@documento, @nombre, @apellido, @fechanacimiento, @fechaingreso)")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@fechanacimiento", fechaNacimiento.ToString("yyyy-MM-dd"));
            comando.Parameters.AddWithValue("@fechaingreso", fechaIngreso.ToString("yyyy-MM-dd"));
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

        public bool AgregarPacienteMenor(string nombre, string apellido, DateTime fechaNacimiento, DateTime fechaIngreso, int idResponsable)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("insert into paciente(nombre, apellido, fechanacimiento, fechaingreso, idresponsable) values (@nombre, @apellido, @fechanacimiento, @fechaingreso, @idresponsable)")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@fechanacimiento", fechaNacimiento.ToString("yyyy-MM-dd"));
            comando.Parameters.AddWithValue("@fechaingreso", fechaIngreso.ToString("yyyy-MM-dd"));
            comando.Parameters.AddWithValue("@idresponsable", idResponsable);
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

        public object AgregarHistMedico(string tipoHist, DateTime fecha, DateTime hora, int idPaciente)
        {
            object ultimoId;
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("insert into histmedico(tipohist, fecha, hora, idpaciente) values (@tipohist, @fecha, @hora, @idpaciente);"
                                                    + "select last_insert_id()")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@tipohist", tipoHist);
            comando.Parameters.AddWithValue("@fecha", fecha.ToString("yyyy-MM-dd"));
            comando.Parameters.AddWithValue("@hora", hora.ToString("HH:mm:ss"));
            comando.Parameters.AddWithValue("@idpaciente", idPaciente);
            try
            {
                comando.Connection.Open();
                ultimoId = comando.ExecuteScalar();
                comando.Connection.Close();
                return ultimoId;
            }
            catch (MySqlException)
            {
                comando.Connection.Close();
                return 0;
            }
        }

        public bool AgregarDetalleCita(int idCita, int idDoctor, int idDiagnostico, string sintomas, string tratamiento)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("insert into detallecita(idcita, iddoctor, iddiagnostico, sintomas, tratamiento) values (@idcita, @iddoctor, @iddiagnostico, @sintomas, @tratamiento)")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idcita", idCita);
            comando.Parameters.AddWithValue("@iddoctor", idDoctor);
            comando.Parameters.AddWithValue("@iddiagnostico", idDiagnostico);
            comando.Parameters.AddWithValue("@sintomas", sintomas);
            comando.Parameters.AddWithValue("@tratamiento", tratamiento);
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

        public bool AgregarAlerta(int idCita, string sintomas, string tratamiento, int uPaciente)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("insert into alerta(idcita, iddiagnostico, sintomas, tratamiento, estado, upaciente) values (@idcita, 1, @sintomas, @tratamiento, 'PENDIENTE', @upaciente)")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idcita", idCita);
            comando.Parameters.AddWithValue("@sintomas", sintomas);
            comando.Parameters.AddWithValue("@tratamiento", tratamiento);
            comando.Parameters.AddWithValue("@upaciente", uPaciente);
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

        public bool AgregarAsignacion(int idPaciente, int idDoctor)
        {
            objConn = conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand("insert into asignacion(idpaciente, iddoctor) values (@idpaciente, @iddoctor)")
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