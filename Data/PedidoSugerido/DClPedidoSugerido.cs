using Entidades.PedidoSugerido;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.PedidoSugerido
{
    public class DClPedidoSugerido
    {
        ClTransacciones transaccion = new ClTransacciones();
        
        /// <summary>
        /// Metodo en donde se lista el maximo valor del id de la tabla para llevar un consegutivo en el pedido
        /// </summary>
        /// <returns></returns>
        private EclPedidoSugerido mtdListarConsecutivo()
        {
            List<EclPedidoSugerido> listaPedidoSugerido = new List<EclPedidoSugerido>();

            try
            {
                string consulta = string.Format(@"select MAX(idPedidoSugerido) as idPedidoSugerido  from PEDIDO_SUGERIDO");

                DataTable tableSugeridos = transaccion.mtdListar(consulta);

                for (int i = 0; i < tableSugeridos.Rows.Count; i++)
                {
                    EclPedidoSugerido pedidoSugerido = new EclPedidoSugerido();

                    if (tableSugeridos.Rows[i]["idPedidoSugerido"] != null)
                    {
                        pedidoSugerido.idPedidoSugerido = int.Parse(tableSugeridos.Rows[i]["idPedidoSugerido"].ToString());

                        listaPedidoSugerido.Add(pedidoSugerido);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listaPedidoSugerido.FirstOrDefault();
        }

        public List<int> mtdInsertarPedidoSugerido(EclPedidoSugerido pedidoSugerido)
        {
            List<int> resultado = new List<int>();

            try
            {
                EclPedidoSugerido consecutivo = mtdListarConsecutivo();

                if (consecutivo != null)
                {
                    pedidoSugerido.consecutivo = "P0000" + (consecutivo.idPedidoSugerido+1);
                }
                else
                {
                    pedidoSugerido.consecutivo = "P00001";
                }

                string consulta = string.Format(@"INSERT INTO PEDIDO_SUGERIDO (consecutivo,estado) VALUES ('{0}','{1}')",
                    pedidoSugerido.consecutivo, pedidoSugerido.estado);
                resultado = transaccion.mtdInsertarIdentity(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar sugeridos: " + ex.Message);
            }

            return resultado;
        }

        /// <summary>
        /// Metodo en donde se lista el pedido sugerido por consecutivo
        /// </summary>
        public List<EClListarPedidoSugeridoGeneral> mtdListarPedidoSugeridoPorConsecutivo(string consecutivo)
        {
            List<EClListarPedidoSugeridoGeneral> listPedidoSugerido = new List<EClListarPedidoSugeridoGeneral>();

            try
            {
                string consulta = string.Format(@"SELECT PS.idPedidoSugerido, PS.consecutivo, S.fecha FROM PEDIDO_SUGERIDO PS INNER JOIN SUGERIDO_PEDIDO_SUGERIDO SPS 
                                                  ON SPS.idPedidoSugerido = PS.idPedidoSugerido INNER JOIN SUGERIDOS S ON SPS.idSugerido = S.idSugerido
                                                  WHERE PS.consecutivo = '{0}' AND PS.estado = 'Activo'", consecutivo);

                DataTable tableSugeridos = transaccion.mtdListar(consulta);

                for (int i = 0; i < tableSugeridos.Rows.Count; i++)
                {
                    EClListarPedidoSugeridoGeneral pedidoSugeridoGeneral = new EClListarPedidoSugeridoGeneral();

                    pedidoSugeridoGeneral.idPedidoSugerido = int.Parse(tableSugeridos.Rows[i]["idPedidoSugerido"].ToString());
                    pedidoSugeridoGeneral.consecutivo = tableSugeridos.Rows[i]["consecutivo"].ToString();
                    pedidoSugeridoGeneral.fecha = DateTime.Parse(tableSugeridos.Rows[i]["fecha"].ToString());

                    listPedidoSugerido.Add(pedidoSugeridoGeneral);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error listar sugerido por consecutivo: " + ex.Message);
            }

            return listPedidoSugerido;
        }

        /// <summary>
        /// Metodo en donde se lista el pedido sugerido por fechas determinadas
        /// </summary>
        public List<EClListarPedidoSugeridoGeneral> mtdListarPedidoSugeridoPorFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<EClListarPedidoSugeridoGeneral> ListaPedidoSugeridoGeneral = new List<EClListarPedidoSugeridoGeneral>();

            try
            {
                string consulta = string.Format(@"SELECT PS.idPedidoSugerido, PS.consecutivo, S.fecha FROM PEDIDO_SUGERIDO PS INNER JOIN SUGERIDO_PEDIDO_SUGERIDO SPS 
                                                  ON SPS.idPedidoSugerido = PS.idPedidoSugerido INNER JOIN SUGERIDOS S ON SPS.idSugerido = S.idSugerido
                                                  WHERE S.fecha BETWEEN '{0}' AND '{1}' AND PS.estado = 'Activo'", fechaInicio.ToString("yyyy-MM-dd"),fechaFin.ToString("yyyy-MM-dd"));

                DataTable tableSugeridos = transaccion.mtdListar(consulta);

                for (int i = 0; i < tableSugeridos.Rows.Count; i++)
                {
                    EClListarPedidoSugeridoGeneral pedidoGeneral = new EClListarPedidoSugeridoGeneral();

                    pedidoGeneral.idPedidoSugerido = int.Parse(tableSugeridos.Rows[i]["idPedidoSugerido"].ToString());
                    pedidoGeneral.consecutivo = tableSugeridos.Rows[i]["consecutivo"].ToString();
                    pedidoGeneral.fecha = DateTime.Parse(tableSugeridos.Rows[i]["fecha"].ToString());

                    ListaPedidoSugeridoGeneral.Add(pedidoGeneral);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error listar sugerido por consecutivo: " + ex.Message);
            }

            return ListaPedidoSugeridoGeneral;
        }

        /// <summary>
        /// Listar Pedido sugerido por id
        /// </summary>
        /// <param name="id"></param>
        public EclPedidoSugerido mtdListarPedidoSugeridoPorId(int id)
        {
            EclPedidoSugerido pedido = new EclPedidoSugerido();
            try
            {
                string consulta = string.Format(@"SELECT PS.idPedidoSugerido, PS.consecutivo, PS.estado FROM PEDIDO_SUGERIDO PS WHERE PS.idPedidoSugerido = {0}", id);

                DataTable tableSugeridos = transaccion.mtdListar(consulta);

                for (int i = 0; i < tableSugeridos.Rows.Count; i++)
                {
                    pedido.idPedidoSugerido = int.Parse(tableSugeridos.Rows[i]["idPedidoSugerido"].ToString());
                    pedido.consecutivo = tableSugeridos.Rows[i]["consecutivo"].ToString();
                    pedido.estado = tableSugeridos.Rows[i]["estado"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return pedido;
        }
    }
}
