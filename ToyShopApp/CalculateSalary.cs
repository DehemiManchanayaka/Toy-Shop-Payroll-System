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
    public partial class CalculateSalary : Form
    {
        public CalculateSalary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();

            Salary sal = new Salary();

            Employee emp = new Employee();
            //employee details
            string[] emp_details = emp.getEmployeeDetails(textBox1.Text);



            string[] salbegincom = dateTimePicker1.Value.Date.ToString().Split(' ');

            string[] salendcom = dateTimePicker2.Value.Date.ToString().Split(' ');


            string[] sett = s.getSettingsVals();



            string[] salbegincom_date = salbegincom[0].Split('/');
            string[] salendcom_date = salendcom[0].Split('/');

            string[] sett_begin_date1 = sett[0].Split(' ');
            string[] sett_end_date1 = sett[1].Split(' ');

            string[] sett_begin_date = sett_begin_date1[0].Split('/');
            string[] sett_end_date = sett_end_date1[0].Split('/');


            int no_of_leaves = Convert.ToInt32(textBox2.Text);
            int no_of_absent = Convert.ToInt32(textBox3.Text);
            int no_of_holidays = Convert.ToInt32(textBox4.Text);


            //MessageBox.Show(salbegincom_date[0] + " " + salendcom_date[0]);

            if (((dateTimePicker2.Value - dateTimePicker1.Value).Days == Convert.ToInt32(sett[2])) && ((salendcom_date[1] == sett_end_date[1]) && (salbegincom_date[1] == sett_begin_date[1])) && (Convert.ToInt32(salendcom_date[0]) > Convert.ToInt32(salbegincom_date[0])) && (no_of_absent >= (no_of_leaves + no_of_holidays)))
            {





                if (Convert.ToInt32(emp_details[7]) >= Convert.ToInt32(textBox2.Text))
                {

                    double[] vals = sal.GetAndSaveSalary(Convert.ToDouble(textBox1.Text), Convert.ToDouble(emp_details[4]), Convert.ToInt32(sett[2]), (no_of_absent - (no_of_leaves + no_of_holidays)), Convert.ToDouble(emp_details[6]), Convert.ToDouble(emp_details[5]), Convert.ToDouble(textBox6.Text), Convert.ToDouble(textBox5.Text), salendcom[0]);

                    label9.Text = "" + vals[0];
                    label10.Text = "" + vals[1];
                    label11.Text = "" + vals[2];


                    emp.updateEmployee("Leaves", Convert.ToString(Convert.ToInt32(emp_details[7]) - Convert.ToInt32(textBox2.Text)), textBox1.Text);

                    MessageBox.Show("Salary Calculation Successfull!");

                }
                else
                {


                    MessageBox.Show("You don't have the entered amount of leaves!");

                }

            }
            else
            {


                MessageBox.Show("Entered Values are not Correct! Please Re-Check!");


            }




        }

        private void CalculateSalary_Load(object sender, EventArgs e)
        {

          


            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalaryMenu sm = new SalaryMenu();
            sm.Visible = true;
            this.Hide();
        }
    }
}
