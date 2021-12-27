using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QL_THUVIEN.DAO
{
    class KetNoi
    {
        public SqlConnection conn;
        public void connect()
        {
            conn = new SqlConnection(@"Data Source=.;Initial Catalog = QL_THUVIEN; Integrated Security = True");
        }
    }
}
