using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace ToyShopApp
{
    public class Settings
    {

        public void addSetting(String SalBeginDate,String SalEndDate,String DateRange,String NoOfLeaves) {

            SqlConnection con = DatabaseConnect.connectDB();

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into Settings(SalaryBeginDate,SalaryEndDate,DateRange,NoOfLeaves) values('"+SalBeginDate+"','"+SalEndDate+"','"+DateRange+"','"+NoOfLeaves+"')";

            cmd.ExecuteReader();

            con.Close();


        }

        public void updateSetting(string field,string val) {

            SqlConnection con = DatabaseConnect.connectDB();

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update Settings set "+field+"='"+val+"' where Id='1'";

            cmd.ExecuteReader();

            con.Close();



        }

        public string[] getSettingsVals() {

            string[] vals = new string[4];

            SqlConnection con = DatabaseConnect.connectDB();

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from Settings";

            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read()) {


                vals[0] = sdr["SalaryBeginDate"].ToString();
                vals[1] = sdr["SalaryEndDate"].ToString();
                vals[2] = sdr["DateRange"].ToString();
                vals[3] = sdr["NoOfLeaves"].ToString();


            }


          

            con.Close();



            return vals;


        }




    }
}
