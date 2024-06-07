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

        private Cart _cart;
        public Menu()
        {
            InitializeComponent();
            _cart = new Cart();
        }

        private void AddToCart(string itemName, decimal price)
        {
            _cart.AddItem(itemName, price);
            MessageBox.Show($"{itemName} added to cart.");
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
            AddToCart("Kis Fluffy", 5.00m);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void chaiLatte_Click(object sender, EventArgs e)
        {
            AddToCart("Chai Latte", 7.00m);
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
            AddToCart("Cappuccino", 8.00m);

        }

        private void latte_Click(object sender, EventArgs e)
        {
            AddToCart("Latte", 10.00m);
        }

        private void hChocolate_Click(object sender, EventArgs e)
        {
            AddToCart("Hot Chocolate", 12.00m);
        }

        private void label1_Click(object sender, EventArgs e) // ice coffee
        {
            AddToCart("Iced Coffee", 8.00m);
        }

        private void longBlack_Click(object sender, EventArgs e)
        {
            AddToCart("Long Black", 15.00m);
        }

        private void flatWhite_Click(object sender, EventArgs e)
        {
            AddToCart("Flat White", 10.00m);
        }

        private void dilmahTea_Click(object sender, EventArgs e)
        {
            AddToCart("Dilmah Tea", 20.00m);
        }

        private void espresso_Click(object sender, EventArgs e)
        {
            AddToCart("Espresso", 10.00m);
        }

        private void label5_Click(object sender, EventArgs e) // eggs benedict
        {
            AddToCart("Eggs Benedict", 14.00m);
        }

        private void label4_Click(object sender, EventArgs e) // chicken strips
        {
            AddToCart("Chicken Strips", 12.00m);
        }

        private void label3_Click(object sender, EventArgs e) // cheese sticks
        {
            AddToCart("Cheese Sticks", 10.00m);
        }

        private void label2_Click(object sender, EventArgs e) // chilli fries
        {
            AddToCart("Chilli Fries", 5.00m);
        }

        private void label6_Click(object sender, EventArgs e) // Donuts
        {
            AddToCart("Donuts", 13.00m);
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm(_cart);
            cartForm.Show();
        }
    }
}
