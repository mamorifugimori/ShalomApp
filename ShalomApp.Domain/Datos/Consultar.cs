namespace ShalomApp.Domain.Datos
{
    using System.Data;
    using MySql.Data.MySqlClient;
    using System;

    class Consultar
    {
        readonly Conexion conexion;
        MySqlConnection objConn;
        public Consultar()
        {
            conexion = new Conexion();
        }

        public DataSet ObtenerEspecialidades()
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            try
            {
                objConn.Open();
                da = new MySqlDataAdapter("select * from especialidad", objConn);
                ds = new DataSet("especialidad");
                da.FillSchema(ds, SchemaType.Source, "especialidad");
                da.Fill(ds, "especialidad");
                objConn.Close();
                return ds;
            }
            catch (MySqlException)
            {
                objConn.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerMedicinasNaturales()
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            try
            {
                objConn.Open();
                da = new MySqlDataAdapter("select * from mednatural", objConn);
                ds = new DataSet("mednatural");
                da.FillSchema(ds, SchemaType.Source, "mednatural");
                da.Fill(ds, "mednatural");
                objConn.Close();
                return ds;
            }
            catch (MySqlException)
            {
                objConn.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerMedNaturalXDiagnostico(int idDiagnostico)
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            MySqlCommand comando = new MySqlCommand("select * from mednatural where iddiagnostico = @iddiagnostico")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@iddiagnostico", idDiagnostico);
            try
            {
                comando.Connection.Open();
                da = new MySqlDataAdapter(comando);
                ds = new DataSet("mednatural");
                da.FillSchema(ds, SchemaType.Source, "mednatural");
                da.Fill(ds, "mednatural");
                comando.Connection.Close();
                return ds;
            }
            catch (MySqlException)
            {
                comando.Connection.Close();
                return new DataSet();
            }
        }
        public DataSet ObtenerDiagnosticos()
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            try
            {
                objConn.Open();
                da = new MySqlDataAdapter("select * from diagnostico", objConn);
                ds = new DataSet("diagnostico");
                da.FillSchema(ds, SchemaType.Source, "diagnostico");
                da.Fill(ds, "diagnostico");
                objConn.Close();
                return ds;
            }
            catch (MySqlException)
            {
                objConn.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerDoctores()
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            try
            {
                objConn.Open();
                da = new MySqlDataAdapter("select * from doctor", objConn);
                ds = new DataSet("doctor");
                da.FillSchema(ds, SchemaType.Source, "doctor");
                da.Fill(ds, "doctor");
                objConn.Close();
                return ds;
            }
            catch (MySqlException)
            {
                objConn.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerParamedicos()
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            try
            {
                objConn.Open();
                da = new MySqlDataAdapter("select * from paramedico", objConn);
                ds = new DataSet("paramedico");
                da.FillSchema(ds, SchemaType.Source, "paramedico");
                da.Fill(ds, "paramedico");
                objConn.Close();
                return ds;
            }
            catch (MySqlException)
            {
                objConn.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerPerfiles()
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            try
            {
                objConn.Open();
                da = new MySqlDataAdapter("select * from perfil", objConn);
                ds = new DataSet("perfil");
                da.FillSchema(ds, SchemaType.Source, "perfil");
                da.Fill(ds, "perfil");
                objConn.Close();
                return ds;
            }
            catch (MySqlException)
            {
                objConn.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerPantallas()
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            try
            {
                objConn.Open();
                da = new MySqlDataAdapter("select * from pantalla", objConn);
                ds = new DataSet("pantalla");
                da.FillSchema(ds, SchemaType.Source, "pantalla");
                da.Fill(ds, "pantalla");
                objConn.Close();
                return ds;
            }
            catch (MySqlException)
            {
                objConn.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerPantallaXPerfil(int idPerfil)
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            MySqlCommand comando = new MySqlCommand("select * from pantalla where idperfil = @idperfil")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idperfil", idPerfil);
            try
            {
                comando.Connection.Open();
                da = new MySqlDataAdapter(comando);
                ds = new DataSet("pantalla");
                da.FillSchema(ds, SchemaType.Source, "pantalla");
                da.Fill(ds, "pantalla");
                comando.Connection.Close();
                return ds;
            }
            catch (MySqlException)
            {
                comando.Connection.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerLogins()
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            try
            {
                objConn.Open();
                da = new MySqlDataAdapter("select * from login", objConn);
                ds = new DataSet("login");
                da.FillSchema(ds, SchemaType.Source, "login");
                da.Fill(ds, "login");
                objConn.Close();
                return ds;
            }
            catch (MySqlException)
            {
                objConn.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerLogin(string alias, string password)
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            MySqlCommand comando = new MySqlCommand("select * from login where alias = @alias and password = @password")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@alias", alias);
            comando.Parameters.AddWithValue("@password", password);
            try
            {
                comando.Connection.Open();
                da = new MySqlDataAdapter(comando);
                ds = new DataSet("login");
                da.FillSchema(ds, SchemaType.Source, "login");
                da.Fill(ds, "login");
                comando.Connection.Close();
                return ds;
            }
            catch (MySqlException)
            {
                comando.Connection.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerPacientes()
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            try
            {
                objConn.Open();
                da = new MySqlDataAdapter("select * from paciente", objConn);
                ds = new DataSet("paciente");
                da.FillSchema(ds, SchemaType.Source, "paciente");
                da.Fill(ds, "paciente");
                objConn.Close();
                return ds;
            }
            catch (MySqlException)
            {
                objConn.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerPacienteXId(int idPaciente)
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            MySqlCommand comando = new MySqlCommand("select * from paciente where idpaciente = @idpaciente")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idpaciente", idPaciente);
            try
            {
                comando.Connection.Open();
                da = new MySqlDataAdapter(comando);
                ds = new DataSet("paciente");
                da.FillSchema(ds, SchemaType.Source, "paciente");
                da.Fill(ds, "paciente");
                comando.Connection.Close();
                return ds;
            }
            catch (MySqlException)
            {
                comando.Connection.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerPacienteXDPI(string dpi)
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            MySqlCommand comando = new MySqlCommand("select * from paciente where documento = @documento")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@documento", dpi);
            try
            {
                comando.Connection.Open();
                da = new MySqlDataAdapter(comando);
                ds = new DataSet("paciente");
                da.FillSchema(ds, SchemaType.Source, "paciente");
                da.Fill(ds, "paciente");
                comando.Connection.Close();
                return ds;
            }
            catch (MySqlException)
            {
                comando.Connection.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerPacienteXNombre(string nombre, string apellido)
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            MySqlCommand comando = new MySqlCommand("select * from paciente where nombre like @nombre and apellido like @apellido")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@nombre", '%'+nombre+'%');
            comando.Parameters.AddWithValue("@apellido", '%'+apellido+'%');
            try
            {
                comando.Connection.Open();
                da = new MySqlDataAdapter(comando);
                ds = new DataSet("paciente");
                da.FillSchema(ds, SchemaType.Source, "paciente");
                da.Fill(ds, "paciente");
                comando.Connection.Close();
                return ds;
            }
            catch (MySqlException)
            {
                comando.Connection.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerHistMedico()
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            try
            {
                objConn.Open();
                da = new MySqlDataAdapter("select * from histmedico", objConn);
                ds = new DataSet("histmedico");
                da.FillSchema(ds, SchemaType.Source, "histmedico");
                da.Fill(ds, "histmedico");
                objConn.Close();
                return ds;
            }
            catch (MySqlException)
            {
                objConn.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerHistMedicoXFechas(DateTime fechaInicial, DateTime fechaFinal)
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            MySqlCommand comando = new MySqlCommand("select * from histmedico where fecha between @fechainicial and @fechafinal")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@fechainicial", fechaInicial.ToString("yyyy-MM-dd"));
            comando.Parameters.AddWithValue("@fechafinal", fechaFinal.ToString("yyyy-MM-dd"));
            try
            {
                comando.Connection.Open();
                da = new MySqlDataAdapter(comando);
                ds = new DataSet("histmedico");
                da.FillSchema(ds, SchemaType.Source, "histmedico");
                da.Fill(ds, "histmedico");
                comando.Connection.Close();
                return ds;
            }
            catch (MySqlException)
            {
                comando.Connection.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerHistMedicoXId(int idCita)
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            MySqlCommand comando = new MySqlCommand("select a.idcita, a.tipohist, a.fecha, a.hora, a.idpaciente, c.iddetalle, concat(b.nombre, ' ', b.apellido) paciente, concat(c.nombre, ' ', c.apellido) asistente, c.sintomas, c.tratamiento, c.iddiagnostico, d.descripcion from histmedico a "
                                                    +"left join paciente b "
                                                    +"on b.idpaciente = a.idpaciente "
                                                    +"left join(select a.idcita, a.idalerta iddetalle, b.nombre, b.apellido, a.iddiagnostico, a.sintomas, a.tratamiento from alerta a "
                                                    +"left join paramedico b "
                                                    +"on b.idparamedico = a.idparamedico "
                                                    +"union all "
                                                    +"select a.idcita, a.iddetallecita, b.nombre, b.apellido, a.iddiagnostico, a.sintomas, a.tratamiento from detallecita a "
                                                    +"left join doctor b "
                                                    +"on b.iddoctor = a.iddoctor) c "
                                                    +"on c.idcita = a.idcita "
                                                    +"left join diagnostico d "
                                                    +"on d.iddiagnostico = c.iddiagnostico "
                                                    +"where a.idcita = @idcita")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idcita", idCita);
            try
            {
                comando.Connection.Open();
                da = new MySqlDataAdapter(comando);
                ds = new DataSet();
                da.Fill(ds);
                comando.Connection.Close();
                return ds;
            }
            catch (MySqlException)
            {
                comando.Connection.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerAlertasPendientes()
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            MySqlCommand comando = new MySqlCommand(
                "select a.idcita, c.idalerta, a.fecha, a.hora, concat(b.nombre, ' ', b.apellido) paciente from histmedico a "
                +"left join paciente b "
                +"on b.idpaciente = a.idpaciente "
                +"left join alerta c "
                +"on c.idcita = a.idcita "
                +"where c.estado = 'PENDIENTE'"
            )
            {
                Connection = objConn
            };
            try
            {
                comando.Connection.Open();
                da = new MySqlDataAdapter(comando);
                ds = new DataSet();
                da.Fill(ds);
                comando.Connection.Close();
                return ds;
            }
            catch (MySqlException)
            {
                objConn.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerAlertasXParamedico(int idParamedico)
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            MySqlCommand comando = new MySqlCommand("select * from alerta where idparamedico = @idparamedico")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idparamedico", idParamedico);
            try
            {
                comando.Connection.Open();
                da = new MySqlDataAdapter(comando);
                ds = new DataSet("alerta");
                da.FillSchema(ds, SchemaType.Source, "alerta");
                da.Fill(ds, "alerta");
                comando.Connection.Close();
                return ds;
            }
            catch (MySqlException)
            {
                comando.Connection.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerAlertaXId(int idAlerta)
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            MySqlCommand comando = new MySqlCommand("select * from alerta where idalerta = @idalerta")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idalerta", idAlerta);
            try
            {
                comando.Connection.Open();
                da = new MySqlDataAdapter(comando);
                ds = new DataSet("alerta");
                da.FillSchema(ds, SchemaType.Source, "alerta");
                da.Fill(ds, "alerta");
                comando.Connection.Close();
                return ds;
            }
            catch (MySqlException)
            {
                comando.Connection.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerAsignaciones()
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            try
            {
                objConn.Open();
                da = new MySqlDataAdapter("select * from asignacion", objConn);
                ds = new DataSet("asignacion");
                da.FillSchema(ds, SchemaType.Source, "asignacion");
                da.Fill(ds, "asignacion");
                objConn.Close();
                return ds;
            }
            catch (MySqlException)
            {
                objConn.Close();
                return new DataSet();
            }
        }

        public DataSet ObtenerAsignacion(int idPaciente, int idDoctor)
        {
            objConn = conexion.ObtenerConexion();
            DataSet ds;
            MySqlDataAdapter da;
            MySqlCommand comando = new MySqlCommand("select * from asignacion where idpaciente = @idpaciente and iddoctor = @iddoctor")
            {
                Connection = objConn
            };
            comando.Parameters.AddWithValue("@idpaciente", idPaciente);
            comando.Parameters.AddWithValue("@iddoctor", idDoctor);
            try
            {
                comando.Connection.Open();
                da = new MySqlDataAdapter(comando);
                ds = new DataSet("asignacion");
                da.FillSchema(ds, SchemaType.Source, "asignacion");
                da.Fill(ds, "asignacion");
                comando.Connection.Close();
                return ds;
            }
            catch (MySqlException)
            {
                comando.Connection.Close();
                return new DataSet();
            }
        }
    }
}