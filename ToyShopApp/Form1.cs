﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin123")
            {


                MainMenu mm = new MainMenu();
                mm.Visible = true;
                this.Hide();

            }
            else
            {

                MessageBox.Show("Invalid username or Password! Please re-try!");




            }


        }
    }
}
