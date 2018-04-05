using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Sugeridos
{
    public class EClSugeridos
    {
        public int id { get; set; }
        public string codigoBarras { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public string embalage { get; set; }
        public int id_departamento { get; set; }
        public int departamento { get; set; }
        public string nombreDepartamento { get; set; }
        public string almacen { get; set; }
        public string fecha { get; set; }
    }
}
