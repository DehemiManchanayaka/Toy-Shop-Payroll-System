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
    public partial class UpdateEmployees : Form
    {
        public UpdateEmployees()
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
            cmd.CommandText = "update EmployeeDetails set "+comboBox1.Text+"='"+textBox2.Text+"' where Id='"+textBox1.Text+"'";

            cmd.ExecuteReader();


            con.Close();

            MessageBox.Show("Succefully updated Details!");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeModule em = new EmployeeModule();
            em.Visible = true;
            this.Hide();



        }
    }
}
