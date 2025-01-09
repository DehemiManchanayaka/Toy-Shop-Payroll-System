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

    //dateTimePicker1.Value.Date.ToString()
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Settings s = new Settings();

            int range = (dateTimePicker2.Value-dateTimePicker1.Value).Days;

            string daterange = textBox1.Text;

            string[]datecom1 = dateTimePicker1.Value.Date.ToString().Split(' ');

            string[] datecom2 = dateTimePicker2.Value.Date.ToString().Split(' ');








            if (range == Convert.ToInt32(daterange))
            {




                s.addSetting(datecom1[0],datecom2[0],daterange,textBox2.Text);

                MessageBox.Show("Successfully Defined the Sample Dates in Settings!");


            }
            else {


                MessageBox.Show("Entered date range is not compatible with defined dates!");


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu sm = new MainMenu();
            sm.Visible = true;
            this.Hide();
        }
    }
}
