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
    public partial class ViewEmployees : Form
    {
        public ViewEmployees()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewIndividual vi = new ViewIndividual();
            vi.Visible = true;
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = DatabaseConnect.connectDB();
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select * from EmployeeDetails where Name like '%"+textBox1.Text+"%'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);


            dataGridView1.DataSource = dt;



            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = DatabaseConnect.connectDB();
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select * from EmployeeDetails", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);


            dataGridView1.DataSource = dt;



            con.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeModule em = new EmployeeModule();
            em.Visible = true;
            this.Hide();
        }
    }
}
