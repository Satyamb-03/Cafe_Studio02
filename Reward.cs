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
    }
}
