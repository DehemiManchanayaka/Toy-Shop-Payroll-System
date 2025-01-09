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
    public partial class ViewIndividual : Form
    {
        public ViewIndividual()
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
            cmd.CommandText = "select * from EmployeeDetails where Id='"+textBox1.Text+"'";

            SqlDataReader sdr = cmd.ExecuteReader();


            string[] empvals = new string[7];
            
            while (sdr.Read()) {

                empvals[0] = sdr["Name"].ToString();
                empvals[1] = sdr["Address"].ToString();
                empvals[2] = sdr["Gender"].ToString();
                empvals[3] = sdr["ContactNo"].ToString();
                empvals[4] = sdr["MonthlySal"].ToString();
                empvals[5] = sdr["OTRate"].ToString();
                empvals[6] = sdr["Allowances"].ToString();






            }


            con.Close();



            EmployeeDetails ed = new EmployeeDetails(empvals[0], empvals[1], empvals[2], empvals[3], empvals[4], empvals[5], empvals[6]);
            ed.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewEmployees ve = new ViewEmployees();
            ve.Visible = true;
            this.Hide();
        }
    }
}
