using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace IceCreamSample
{
    public class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            string con = "Data Source=localhost;Initial Catalog=IceCream;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            return new SqlConnection(con);
        }
    }
}
