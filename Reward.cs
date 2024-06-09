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
    public partial class Reward : Form
    {
        public Reward()
        {
            InitializeComponent();
        }

        private void Reward_Load(object sender, EventArgs e)
        {

        }

        private void ordertomenu_button_Click(object sender, EventArgs e)
        {
            Menu form2 = new Menu();

            // Show the menu form
            form2.Show();

            Program.SwitchForm(this, form2);
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            Program.SwitchForm(this, form1);
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            Menu form2= new Menu();
            form2.Show();
            Program.SwitchForm(this, form2);
        }

        private void login_Click(object sender, EventArgs e)
        {
            login form4 = new login();
            form4.Show();

            Program.SwitchForm(this, form4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            Program.SwitchForm(this, form7);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
