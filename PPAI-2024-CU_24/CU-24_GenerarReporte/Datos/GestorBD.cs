using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Datos
{
    public class GestorBD
    {
        private string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaBD"];

        public GestorBD()
        {
           
        }


        public DataTable obtener_Paises()
        {
            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaBD"];
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection(this.cadenaConexion);

            string consulta = "SELECT * FROM Pais";

            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;

            conexion.Open();

            comando.Connection = conexion;

            DataTable tabla = new DataTable();

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);

            conexion.Close();
            return tabla;

        }
        //funcion  para trare una tabla ingresada por parametro
        public DataTable obtener_Tabla(string nombreTabla)
        {
            //string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaBD"];
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection(this.cadenaConexion);

            string consulta = "SELECT * FROM " + nombreTabla;

            comando.Parameters.Clear();
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;

            conexion.Open();

            comando.Connection = conexion;

            DataTable tabla = new DataTable();

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);

            conexion.Close();
            return tabla;

        }
    }
}
