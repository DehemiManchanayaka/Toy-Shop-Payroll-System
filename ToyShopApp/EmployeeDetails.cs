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
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails(string name,string address,string gender,string contactno,string monthlysal,string otrate,string allowances)
        {
            InitializeComponent();

            label14.Text = name;
            label13.Text = address;
            label12.Text = gender;
            label11.Text = contactno;
            label10.Text = monthlysal;
            label9.Text = otrate;
            label8.Text = allowances;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
