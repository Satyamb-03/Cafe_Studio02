﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Studio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu form2 = new Menu();

            // Show the new form
            form2.Show();

            Program.SwitchForm(this, form2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            
            Program.SwitchForm(this, form4);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7= new Form7();
            form7.Show();

            Program.SwitchForm(this, form7);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
