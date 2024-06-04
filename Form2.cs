using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            Program.SwitchForm(this,form1);

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void chaiLatte_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            login form4 = new login();
            form4.Show();

            Program.SwitchForm(this,form4);

        }

        private void Promotional_Click(object sender, EventArgs e)
        {
            Promotional form = new Promotional();
            form.Show();

            Program.SwitchForm(this, form);
        }

        private void Reward_Click(object sender, EventArgs e)
        {
            Reward form = new Reward();
            form.Show();

            Program.SwitchForm(this, form);
        }

        private void Cappuccino_Click(object sender, EventArgs e)
        {

        }

        private void latte_Click(object sender, EventArgs e)
        {

        }

        private void hChocolate_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e) // ice coffee
        {

        }

        private void longBlack_Click(object sender, EventArgs e)
        {

        }

        private void flatWhite_Click(object sender, EventArgs e)
        {

        }

        private void dilmahTea_Click(object sender, EventArgs e)
        {

        }

        private void espresso_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e) // eggs benedict
        {

        }

        private void label4_Click(object sender, EventArgs e) // chicken strips
        {

        }

        private void label3_Click(object sender, EventArgs e) // cheese sticks
        {

        }

        private void label2_Click(object sender, EventArgs e) // chilli fries
        {

        }

        private void label6_Click(object sender, EventArgs e) // Donuts
        {

        }
    }
}
