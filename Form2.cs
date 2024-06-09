using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Cafe_Studio02
{
    public partial class Menu : Form
    {
        // Private field to hold the cart object
        private Cart _cart;
        public Menu()
        {
            InitializeComponent();
            // Create a new instance of the Cart and assign it to the _cart field
            _cart = new Cart();
        }

        /// Adds an item to the shopping cart and displays a message indicating the item was added.
        private void AddToCart(string itemName, decimal price)
        {
            _cart.AddItem(itemName, price);
            // Display a message box to the user indicating the item has been added to the cart
            MessageBox.Show($"{itemName} added to cart.");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new instance of Form1
            Form1 form1 = new Form1();
            form1.Show();
            // Switch the current form to the new Form1 instance
            Program.SwitchForm(this,form1);

        }
        // Add the item "Kis Fluffy" with a price of $5.00 to the cart
        private void label8_Click(object sender, EventArgs e)
        {
            AddToCart("Kis Fluffy", 5.00m);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        // Add the item "Chai Latta" with a price of $7.00 to the cart
        private void chaiLatte_Click(object sender, EventArgs e)
        {
            AddToCart("Chai Latte", 7.00m);
        }

        private void login_Click(object sender, EventArgs e)
        {
            // Create a new instance of the login form
            login form4 = new login();
            // Display the new login form
            form4.Show();

            Program.SwitchForm(this,form4);

        }

        private void Promotional_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Promotional form
            Promotional form = new Promotional();
            // Display the new Promotional form
            form.Show();

            Program.SwitchForm(this, form);
        }
        /// Adds a Cappuccino to the cart with a price of $8.00.
        private void Cappuccino_Click(object sender, EventArgs e)
        {
            AddToCart("Cappuccino", 8.00m);

        }
        // Adds a Latte to the cart with a price of $10.00.
        private void latte_Click(object sender, EventArgs e)
        {
            AddToCart("Latte", 10.00m);
        }
        // Adds a Hot Chocolate to the cart with a price of $12.00.
        private void hChocolate_Click(object sender, EventArgs e)
        {
            AddToCart("Hot Chocolate", 12.00m);
        }
        // Adds an Iced Coffee to the cart with a price of $8.00.
        private void label1_Click(object sender, EventArgs e) // ice coffee
        {
            AddToCart("Iced Coffee", 8.00m);
        }
        // Adds a Long Black to the cart with a price of $15.00.
        private void longBlack_Click(object sender, EventArgs e)
        {
            AddToCart("Long Black", 15.00m);
        }
        // Adds a Flat White to the cart with a price of $10.00.
        private void flatWhite_Click(object sender, EventArgs e)
        {
            AddToCart("Flat White", 10.00m);
        }
        // Adds a Dilmah Tea to the cart with a price of $20.00.
        private void dilmahTea_Click(object sender, EventArgs e)
        {
            AddToCart("Dilmah Tea", 20.00m);
        }
        // Adds an Espresso to the cart with a price of $10.00.
        private void espresso_Click(object sender, EventArgs e)
        {
            AddToCart("Espresso", 10.00m);
        }
        // Adds Eggs Benedict to the cart with a price of $14.00.
        private void label5_Click(object sender, EventArgs e) // eggs benedict
        {
            AddToCart("Eggs Benedict", 14.00m);
        }
        // Adds Chicken Strips to the cart with a price of $12.00.
        private void label4_Click(object sender, EventArgs e) // chicken strips
        {
            AddToCart("Chicken Strips", 12.00m);
        }

        private void label3_Click(object sender, EventArgs e) // cheese sticks
        {
            AddToCart("Cheese Sticks", 10.00m);
        }
        // Adds Chilli Fries to the cart with a price of $5.00.
        private void label2_Click(object sender, EventArgs e) // chilli fries
        {
            AddToCart("Chilli Fries", 5.00m);
        }

        // Adds Donuts to the cart with a price of $13.00.
        private void label6_Click(object sender, EventArgs e) // Donuts
        {
            AddToCart("Donuts", 13.00m);
        }
      //  Opens a new instance of the CartForm and shows the current items in the cart.
        private void buttonCart_Click(object sender, EventArgs e)
        {
            // Create a new instance of the CartForm with the current cart
            CartForm cartForm = new CartForm(_cart);
            cartForm.Show();
        }
    }
}
