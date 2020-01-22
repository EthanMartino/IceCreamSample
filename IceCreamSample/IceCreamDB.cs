using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace IceCreamSample
{
    public class IceCreamDB
    {
        public static void Add(IceCream ice)
        {
            //Establish Connection
            SqlConnection con = DBHelper.GetConnection();

            //Set Up Queries
            SqlCommand addCmd = new SqlCommand();
            addCmd.Connection = con;
            addCmd.CommandText =
                "INSERT INTO IceCream(Flavor, Scoops, Container)" +
                    "VALUES(@Flavor, @Scoops, @Container)";
            addCmd.Parameters.AddWithValue("@Flavor", ice.Flavor);
            addCmd.Parameters.AddWithValue("@Scoops", ice.Scoops);
            addCmd.Parameters.AddWithValue("@Container", ice.Container);

            //Open connection, Execute, and finally Dispose of connection
            try
            {
                con.Open();
                addCmd.ExecuteNonQuery();
            }
            finally
            {
                con.Dispose();
            }
        }
    }
}
