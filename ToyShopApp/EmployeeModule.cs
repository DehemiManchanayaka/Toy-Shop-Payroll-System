using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyShopApp
{
    public partial class EmployeeModule : Form
    {
        public EmployeeModule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            RegisterEmployee re = new RegisterEmployee();
            re.Visible = true;
            this.Hide();



        }

        private void button2_Click(object sender, EventArgs e)
        {

            UpdateEmployees ue = new UpdateEmployees();
            ue.Visible = true;
            this.Hide();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteEmployee de = new DeleteEmployee();
            de.Visible = true;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewEmployees ve = new ViewEmployees();
            ve.Visible = true;
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainMenu sm = new MainMenu();
            sm.Visible = true;
            this.Hide();
        }
    }
}
