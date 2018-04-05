using Data.PedidoSugerido;
using Entidades.PedidoSugerido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.PedidoSugerido
{
    public class LClPedidoSugerido
    {
        DClPedidoSugerido objDPedidoSugerido = new DClPedidoSugerido();

        public List<int> mtdInsertarPedidoSugerido(EclPedidoSugerido pedidoSugerido)
        => objDPedidoSugerido.mtdInsertarPedidoSugerido(pedidoSugerido);

        public List<EClListarPedidoSugeridoGeneral> mtdListarPedidoSugeridoPorConsecutivo(string consecutivo)
            => objDPedidoSugerido.mtdListarPedidoSugeridoPorConsecutivo(consecutivo);

        public List<EClListarPedidoSugeridoGeneral> mtdListarPedidoSugeridoPorFechas(DateTime fechaInicio, DateTime fechaFin)
            => objDPedidoSugerido.mtdListarPedidoSugeridoPorFechas(fechaInicio,fechaFin);

        public EclPedidoSugerido mtdListarPedidoSugeridoPorId(int id)
            => objDPedidoSugerido.mtdListarPedidoSugeridoPorId(id);
    }
}
