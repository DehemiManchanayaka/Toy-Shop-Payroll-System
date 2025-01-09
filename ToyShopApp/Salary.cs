using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace ToyShopApp
{
    public class Salary
    {


        public double NoPayValue(double totalSal,int salDateRange,int absentDays) {


            double NoPayVal = 0;

            NoPayVal = (totalSal / salDateRange) * absentDays;

            return NoPayVal;

        }


        public double BasePayValue(double totalSal,double allowances,double OTRate,double OTHours) {

            double BasePayVal = totalSal  + allowances + (OTRate * OTHours);

            return BasePayVal;



        }

        public double GrossPay(double BasePayVal,double NoPayVal,double govTaxRate) {


            double GrossPay = BasePayVal - (NoPayVal + ((BasePayVal * govTaxRate)/100));

            return GrossPay;


        }


        public double[] GetAndSaveSalary(double empId,double totalSal,int salDateRange,int absentDays,double allowances,double OTRate,double OTHours,double govTaxRate,string SalDate) {

            double[] salary = new double[3];


            salary[0] = NoPayValue(totalSal,salDateRange,absentDays);
            salary[1] = BasePayValue(totalSal,allowances,OTRate,OTHours);
            salary[2] = GrossPay(salary[1],salary[0],govTaxRate);


            SqlConnection con=DatabaseConnect.connectDB();

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into Salary(EmpId,NoPayVal,BasePayVal,GrossPayVal,SalaryMonth) values('" + empId+"','"+salary[0]+"','"+salary[1]+"','"+salary[2]+"','"+SalDate+"')";

            cmd.ExecuteReader();

            con.Close();



            return salary;
        }


        public DataTable getIndividualSal(string empid,string date) {

            string[] individual_sal = new string[4];

            SqlConnection con = DatabaseConnect.connectDB();


            SqlDataAdapter sda = new SqlDataAdapter("select * from Salary where EmpId='" + empid + "' and SalaryMonth='" + date + "'",con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            return dt;
        
        }


        public DataTable getSalaryRecordsMonthlyRange(string empid,string start_date,string end_date) {


            SqlConnection con = DatabaseConnect.connectDB();

            SqlDataAdapter sda;
            
            if(empid!=""){
                sda= new SqlDataAdapter("select * from Salary where EmpId='"+empid+"' and SalaryMonth between '"+start_date+"' and '"+end_date+"'",con);
            }
            else{

                sda = new SqlDataAdapter("select * from Salary where SalaryMonth between '" + start_date + "' and '" + end_date + "'", con);
            
            
            }
            DataTable dt = new DataTable();

            sda.Fill(dt);

            return dt;
        
        }





    }
}
