using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ClTransacciones
    {
        ClConexion conexion = new ClConexion(); //Instacia de la cadena de conexion
        SqlConnection cn;
        SqlDataAdapter adpt;
        SqlCommand slcmd;
        DataTable table;

        /// <summary>
        /// Peticiones para retornar tablas
        /// </summary>
        /// <param name="consulta">Consulta sql</param>
        /// <returns></returns>
        public DataTable mtdListar(string consulta)
        {
            table = new DataTable();

            try
            {
                cn = conexion.mtdConexion();
                adpt = new SqlDataAdapter(consulta, cn);
                adpt.Fill(table);
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error peticion de listar" + ex.Message);
            }

            return table;
        }

        /// <summary>
        /// Metodo para realizar transacciones de insert a la bd devolviendo un numero en binario confirmando la transaccion
        /// </summary>
        /// <param name="consulta">Consulta Sql</param>
        /// <returns></returns>
        public List<int> mtdInsertarIdentity(string consulta)
        {
            List<int> resultado = new List<int>();

            try
            {
                cn = conexion.mtdConexion();
                cn.Open();
                slcmd = new SqlCommand(consulta,cn);
                resultado.Add(slcmd.ExecuteNonQuery());
                slcmd.Parameters.Clear();
                slcmd.CommandText = "SELECT @@IDENTITY";
                object a = slcmd.ExecuteScalar();
                resultado.Add(int.Parse(a.ToString()));
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar: "+ex.Message);
            }

            return resultado;
        }

        /// <summary>
        /// Metodo para realizar transacciones de insert 
        /// </summary>
        /// <param name="consulta">Consulta Sql</param>
        /// <returns></returns>
        public int mtdInsertar(string consulta)
        {
            int resultado = 0;

            try
            {
                cn = conexion.mtdConexion();
                cn.Open();
                slcmd = new SqlCommand(consulta, cn);
                resultado = slcmd.ExecuteNonQuery();
                slcmd.Parameters.Clear();
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar: " + ex.Message);
            }

            return resultado;
        }
    }
}
