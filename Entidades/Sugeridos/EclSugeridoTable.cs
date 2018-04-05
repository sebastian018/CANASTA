using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Sugeridos
{
    public class EclSugeridoTable
    {
        public int idSugerido { get; set; }
        public string codigo_barras { get; set; }
        public string descripcion_producto { get; set; }
        public int cantidad { get; set; }
        public string embalaje { get; set; }
        public int id_departamento { get; set; }
        public string descipcion_departamento { get; set; }
        public int almacen { get; set; }
        public DateTime fecha { get; set; }
    }
}
