using Entidades.Sugeridos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Sugeridos
{
    public class ClSugeridos
    {
        ClTransacciones transaccion = new ClTransacciones();

        public List<EClSugeridos> mtdListarProducto(string codigoBarras)
        {
            List<EClSugeridos> listaSugeridos = new List<EClSugeridos>();
            try
            {
                string consulta = string.Format(@"SELECT  * FROM 
                    (
                    SELECT CONVERT(VARCHAR(40), AL.CODBARRAS) AS CODBARRAS
                    , CONVERT(VARCHAR(40), AR.DESCRIPCION) AS DESCRIPCION, AR.DPTO AS DEPARTAMENTO, DE.DESCRIPCION AS NOMBRE_DEPARTAMENTO
                    FROM ARTICULOSLIN AL WITH (NOLOCK) INNER JOIN ARTICULOS AR WITH (NOLOCK) 
                    ON AL.CODARTICULO = AR.CODARTICULO INNER JOIN DEPARTAMENTO DE WITH (NOLOCK) ON AR.DPTO = DE.NUMDPTO
                    WHERE AR.DESCATALOGADO = 'F'
                    
                    UNION ALL
                    
                    SELECT CONVERT(VARCHAR(40), AL.CODBARRAS2) AS CODBARRAS
                    , CONVERT(VARCHAR(40), AR.DESCRIPCION) AS DESCRIPCION, AR.DPTO AS DEPARTAMENTO, DE.DESCRIPCION AS NOMBRE_DEPARTAMENTO
                    FROM ARTICULOSLIN AL WITH (NOLOCK) INNER JOIN ARTICULOS AR WITH (NOLOCK) 
                    ON AL.CODARTICULO = AR.CODARTICULO INNER JOIN DEPARTAMENTO DE WITH (NOLOCK) ON AR.DPTO = DE.NUMDPTO
                    WHERE AR.DESCATALOGADO = 'F'
                    
                    UNION ALL
                    
                    SELECT CONVERT(VARCHAR(40), AL.CODBARRAS3) AS CODBARRAS
                    , CONVERT(VARCHAR(40), AR.DESCRIPCION) AS DESCRIPCION, AR.DPTO AS DEPARTAMENTO, DE.DESCRIPCION AS NOMBRE_DEPARTAMENTO
                    FROM ARTICULOSLIN AL WITH (NOLOCK) INNER JOIN ARTICULOS AR WITH (NOLOCK) 
                    ON AL.CODARTICULO = AR.CODARTICULO INNER JOIN DEPARTAMENTO DE WITH (NOLOCK) ON AR.DPTO = DE.NUMDPTO
                    WHERE AR.DESCATALOGADO = 'F'
                    
                    )AS AL
                    WHERE AL.CODBARRAS = '{0}'", codigoBarras);

                DataTable tableSugeridos = transaccion.mtdListar(consulta);

                for (int i = 0; i < tableSugeridos.Rows.Count; i++)
                {
                    EClSugeridos sugeridos = new EClSugeridos();

                    sugeridos.departamento = int.Parse(tableSugeridos.Rows[i]["DEPARTAMENTO"].ToString());
                    sugeridos.descripcion = tableSugeridos.Rows[i]["DESCRIPCION"].ToString();
                    sugeridos.nombreDepartamento = tableSugeridos.Rows[i]["NOMBRE_DEPARTAMENTO"].ToString();
                    sugeridos.codigoBarras = tableSugeridos.Rows[i]["CODBARRAS"].ToString();

                    listaSugeridos.Add(sugeridos);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar sugeridos: "+ex.Message);
            }

            return listaSugeridos;
        }

        /// <summary>
        /// Metodo en donde se genera consulta Insert a tabla de sugeridos
        /// </summary>
        /// <param name="sugerido">Objeto cargado con la data a insertar</param>
        /// <returns></returns>
        public List<int> mtdInsertarSugerido(EclSugeridoTable sugerido)
        {
            List<int> resultado = new List<int>();

            try
            {
                string consulta = string.Format(@"INSERT INTO SUGERIDOS (codigo_barras,descripcion_producto,cantidad,embalaje,
                                                id_departamento,descipcion_departamento,almacen,fecha) VALUES ('{0}','{1}',{2},'{3}',{4},
                                                '{5}','{6}','{7}')", sugerido.codigo_barras, sugerido.descripcion_producto, sugerido.cantidad,
                                                  sugerido.embalaje,sugerido.id_departamento,sugerido.descipcion_departamento, sugerido.almacen,
                                                  sugerido.fecha);
                resultado = transaccion.mtdInsertarIdentity(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar sugeridos: " + ex.Message);
            }

            return resultado;
        }

        DataTable tblSugeridos = new DataTable();


        public List<EClSugeridos> mtdListarSugerido()
        {
            string sql = "";

            sql = "SELECT codigo_barras,descripcion_producto,cantidad,embalaje,descipcion_departamento FROM Sugeridos_Almacen";

            tblSugeridos = transaccion.mtdListar(sql);

            List<EClSugeridos> listaSugeridos = new List<EClSugeridos>();

            for (int i = 0; i < tblSugeridos.Rows.Count; i++)
            {
                EClSugeridos objSugerido = new EClSugeridos();
                objSugerido.codigoBarras = tblSugeridos.Rows[i]["codigo_barras"].ToString();
                objSugerido.descripcion = tblSugeridos.Rows[i]["descripcion_producto"].ToString();
                objSugerido.cantidad = int.Parse(tblSugeridos.Rows[i]["cantidad"].ToString());
                objSugerido.embalage = tblSugeridos.Rows[i]["embalaje"].ToString();
                objSugerido.nombreDepartamento = tblSugeridos.Rows[i]["descipcion_departamento"].ToString();

                listaSugeridos.Add(objSugerido);
            }

            return listaSugeridos;
        }

        /// <summary>
        /// Metodo en donde se listan los sugeridos por el id del pedido
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<EclSugeridoTable> mtdListarSugeridosPorPedido(int id)
        {
            List<EclSugeridoTable> listSugeridos = new List<EclSugeridoTable>();

            try
            {
                string consulta = string.Format(@"SELECT SUGERIDO.idSugerido, SUGERIDO.id_departamento, SUGERIDO.fecha, SUGERIDO.embalaje, SUGERIDO.descripcion_producto, 
                                                  SUGERIDO.descipcion_departamento, SUGERIDO.codigo_barras, SUGERIDO.cantidad from SUGERIDOS SUGERIDO INNER JOIN SUGERIDO_PEDIDO_SUGERIDO SPS
                                                  ON SPS.idSugerido = SUGERIDO.idSugerido INNER JOIN PEDIDO_SUGERIDO PS ON PS.idPedidoSugerido = SPS.idPedidoSugerido
                                                  WHERE PS.idPedidoSugerido = {0} ORDER BY SUGERIDO.descipcion_departamento", id);

                DataTable tblSugeridos = transaccion.mtdListar(consulta);

                for (int i = 0; i < tblSugeridos.Rows.Count; i++)
                {
                    EclSugeridoTable objSugerido = new EclSugeridoTable();

                    objSugerido.idSugerido = int.Parse(tblSugeridos.Rows[i]["idSugerido"].ToString());
                    objSugerido.id_departamento = int.Parse(tblSugeridos.Rows[i]["id_departamento"].ToString());
                    objSugerido.fecha = DateTime.Parse(tblSugeridos.Rows[i]["fecha"].ToString());
                    objSugerido.embalaje = tblSugeridos.Rows[i]["embalaje"].ToString();
                    objSugerido.descripcion_producto = tblSugeridos.Rows[i]["descripcion_producto"].ToString();
                    objSugerido.descipcion_departamento = tblSugeridos.Rows[i]["descipcion_departamento"].ToString();
                    objSugerido.codigo_barras = tblSugeridos.Rows[i]["codigo_barras"].ToString();
                    objSugerido.cantidad = int.Parse(tblSugeridos.Rows[i]["cantidad"].ToString());

                    listSugeridos.Add(objSugerido);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar sugeridos por pedido: " + ex.Message);
            }

            return listSugeridos;
        }
    }
}
