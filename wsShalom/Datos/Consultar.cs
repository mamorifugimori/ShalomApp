using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using MySql.Data.MySqlClient;

namespace wsShalom.Datos
{
    public class Consultar
    {
        Conexion conexion;
        MySqlConnection objConn;
        public Consultar()
        {
            conexion = new Conexion();
        }

        public DataSet obtenerEspecialidades()
        {
            objConn = conexion.obtenerConexion();
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

        public DataSet obtenerDoctores()
        {
            objConn = conexion.obtenerConexion();
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
    }
}