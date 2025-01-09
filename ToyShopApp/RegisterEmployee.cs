using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace ToyShopApp
{
    public partial class RegisterEmployee : Form
    {
        public RegisterEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           SqlConnection con = DatabaseConnect.connectDB();
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from Settings";

            SqlDataReader sdr = cmd.ExecuteReader();

            string leaves="";
            while(sdr.Read()){

                leaves = sdr["NoOfLeaves"].ToString();
            
            
            }

            con.Close();

            con.Open();

            cmd.CommandText = "insert into EmployeeDetails(Name,Address,Gender,ContactNo,MonthlySal,OTRate,Allowances,Leaves) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + leaves + "')";

            cmd.ExecuteReader();


            con.Close();

            MessageBox.Show("Successfully inserted All the Data!");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            EmployeeModule em = new EmployeeModule();
            em.Visible = true;
            this.Hide();
        }
    }
}
