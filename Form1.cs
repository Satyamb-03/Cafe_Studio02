// Satyam Bhatt
// ===========================
// Cafe Desktop App
// Studio 02
// Home Page
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

            
            form2.Show();// Shows the new form.

            Program.SwitchForm(this, form2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            login form4 = new login();
            form4.Show();// Shows the new form.

            Program.SwitchForm(this, form4);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7= new Form7();
            form7.Show();// Shows the new form.

            Program.SwitchForm(this, form7);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Rewards_Click(object sender, EventArgs e)
        {
            Promotional form=new Promotional();
            form.Show();// Shows the new form.

            Program.SwitchForm(this, form); 
        }
    }
}
