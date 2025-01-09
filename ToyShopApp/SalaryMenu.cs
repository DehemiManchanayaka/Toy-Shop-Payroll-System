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
    public partial class SalaryMenu : Form
    {
        public SalaryMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateSalary cs = new CalculateSalary();
            cs.Visible = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MonthlySalReport msr = new MonthlySalReport();
            msr.Visible = true;
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalarySummaryMonthsEmployee ssme = new SalarySummaryMonthsEmployee();
            ssme.Visible = true;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SalaryMonthlyRange smr = new SalaryMonthlyRange();
            smr.Visible = true;
            this.Hide();
        }
    }
}
