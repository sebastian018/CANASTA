using Entidades.SugeridoPedidoSugerido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.SugeridoPedidoSugerido
{
    public class DClSugeridoPedidoSugerido
    {
        ClTransacciones transaccion = new ClTransacciones();

        public int mtdInsertarSugeridoPedidoSugerido(EClSugeridoPedidoSugerido sugeridoPedidoSugerido)
        {
            int resultado = 0;

            try
            {
                string consulta = string.Format(@"INSERT INTO SUGERIDO_PEDIDO_SUGERIDO (idSugerido,idPedidoSugerido) VALUES ('{0}','{1}')",
                    sugeridoPedidoSugerido.idSugerido, sugeridoPedidoSugerido.idPedidoSugerido);

                resultado = transaccion.mtdInsertar(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar sugerido pedido sugerido: " + ex.Message);
            }

            return resultado;
        }
    }
}
