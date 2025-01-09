using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace ToyShopApp
{
    public class Employee
    {

        public string[] getEmployeeDetails(string empid) {


            string[] vals = new string[8];

            SqlConnection con = DatabaseConnect.connectDB();

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from EmployeeDetails where Id='"+empid+"'";

            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {


                vals[0] = sdr["Name"].ToString();
                vals[1] = sdr["Address"].ToString();
                vals[2] = sdr["Gender"].ToString();
                vals[3] = sdr["ContactNo"].ToString();
                vals[4] = sdr["MonthlySal"].ToString();
                vals[5] = sdr["OTRate"].ToString();
                vals[6] = sdr["Allowances"].ToString();
                vals[7]= sdr["Leaves"].ToString();

            }


          

            con.Close();



            return vals;





        }

        public void updateEmployee(string field,string val,string empid) {

            SqlConnection con = DatabaseConnect.connectDB();
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update EmployeeDetails set " + field + "='" + val + "' where Id='" + empid + "'";

            cmd.ExecuteReader();


            con.Close();

         





        }


    }
}
