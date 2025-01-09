using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace ToyShopApp
{
    public class DatabaseConnect
    {

        public static SqlConnection con = new SqlConnection();

        public static SqlConnection connectDB() {

            con.ConnectionString = "Data Source=DESKTOP-KTR4HM9;Initial Catalog=ToyDB;Integrated Security=True";

            return con;

        }

        



    }
}
