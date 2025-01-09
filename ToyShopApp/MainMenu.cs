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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeModule em = new EmployeeModule();
            em.Visible = true;
            this.Hide();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalaryMenu cs = new SalaryMenu();
            cs.Visible = true;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SettingsForm sf = new SettingsForm();
            sf.Visible = true;
            this.Hide();

        }
    }
}
