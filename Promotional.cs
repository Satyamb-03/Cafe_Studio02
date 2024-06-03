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
    public partial class Promotional : Form
    {
        public Promotional()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Promotional_Load(object sender, EventArgs e)
        {

        }

        private void home_button_Click(object sender, EventArgs e)
        {

        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            Menu form2 = new Menu();
            form2.Show();
            Program.SwitchForm(this, form2);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           login from4 = new login();
            from4.Show();
            Program.SwitchForm(this, from4);
        }

        private void Contactus_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            Program.SwitchForm(this, form7);
        }
    }
}
