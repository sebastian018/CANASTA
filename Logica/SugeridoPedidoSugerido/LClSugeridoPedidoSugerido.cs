using Data.PedidoSugerido;
using Data.SugeridoPedidoSugerido;
using Entidades.SugeridoPedidoSugerido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.SugeridoPedidoSugerido
{
    public class LClSugeridoPedidoSugerido
    {
        DClSugeridoPedidoSugerido objDSugeridoPedidoSugerido = new DClSugeridoPedidoSugerido();

        public int mtdInsertarPedidoSugerido(EClSugeridoPedidoSugerido pedidoSugerido)
            => objDSugeridoPedidoSugerido.mtdInsertarSugeridoPedidoSugerido(pedidoSugerido);
    }
}
