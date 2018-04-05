using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ClConexion
    {
        protected string cadenadeconex;
        protected SqlConnection cnn;

        public SqlConnection mtdConexion()
        {
            //this.cadenadeconex = (@"Data Source=192.168.102.101, 1433; Initial Catalog=ICGVALDEZ; User ID=sa; Password=Masterkey2008;");
            this.cadenadeconex = (@"Data Source=DESKTOP-1IVQ2MF;Initial Catalog=ICGVALDEZ;Integrated Security=True");
            this.cnn = new SqlConnection(this.cadenadeconex);
            return cnn;
        }
    }
}
