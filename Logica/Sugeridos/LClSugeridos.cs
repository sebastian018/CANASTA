using Data.Sugeridos;
using Entidades.Sugeridos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entidades;


namespace Logica.Sugeridos
{
    public class LClSugeridos
    {
        ClSugeridos sugeridos = new ClSugeridos();

        public List<EClSugeridos> mtdListarProducto(string codigoBarras)
        => sugeridos.mtdListarProducto(codigoBarras);
          

        public List<int> mtdInsertarSugerido(EclSugeridoTable sugerido)
            => sugeridos.mtdInsertarSugerido(sugerido);

        public List<EClSugeridos> mtdListarSugerido()
          => sugeridos.mtdListarSugerido();

        public List<EclSugeridoTable> mtdListarSugeridosPorPedido(int id)
            => sugeridos.mtdListarSugeridosPorPedido(id);
    }

}
