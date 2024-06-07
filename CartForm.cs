using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Cafe_Studio02
{
    public partial class CartForm : Form
    {

        private Cart _cart;
        private string _selectedCoffee;
        public CartForm()
        {
            InitializeComponent();
           
        }

        private void CartForm_Load(object sender, EventArgs e)
        {

        }


        public CartForm(Cart cart)
        {
            InitializeComponent();
            _cart = cart;
            LoadCartItems();
        }

        private void LoadCartItems()
        {
            listView1.Items.Clear();
            foreach (var item in _cart.Items)
            {
                var listViewItem = new ListViewItem(item.Name);
                listViewItem.SubItems.Add(item.Price.ToString("C"));
                listViewItem.SubItems.Add(item.Quantity.ToString());
                listViewItem.SubItems.Add((item.Price * item.Quantity).ToString("C"));
                listView1.Items.Add(listViewItem);
            }
            labelTotal.Text = $"Total: {_cart.Total:C}";
        }

        private void buttonUpdateQuantity_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                var itemName = selectedItem.Text;
                if (int.TryParse(textBoxQuantity.Text, out int quantity))
                {
                    var item = _cart.Items.FirstOrDefault(i => i.Name == itemName);
                    if (item != null)
                    {
                        item.Quantity = quantity;
                        LoadCartItems();
                    }
                }
            }
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total amount: {_cart.Total:C}");
            // Implement checkout logic
        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdateQuantity_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                string itemName = selectedItem.SubItems[0].Text;
                if (int.TryParse(textBoxQuantity.Text, out int quantity) && quantity > 0)
                {
                    _cart.UpdateQuantity(itemName, quantity);
                    LoadCartItems();
                }
                else
                {
                    MessageBox.Show("Please enter a valid quantity.");
                }
            }
            else
            {
                MessageBox.Show("Please select an item to update.");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                var itemName = selectedItem.Text;
                var item = _cart.Items.FirstOrDefault(i => i.Name == itemName);
                if (item != null)
                {
                    _selectedCoffee = item.Name;
                    comboBoxSize.SelectedItem = item.Size;
                    checkBoxSoyMilk.Checked = item.AddOns.Contains("Soy Milk");
                    checkOatBoxMilk.Checked = item.AddOns.Contains("Oat Milk");
                    checkBoxNoSugar.Checked = item.AddOns.Contains("No Sugar");
                    panelCustomization.Visible = true;
                }
            }
            else
            {
                panelCustomization.Visible = false;
            }
        }

        private void buttonSaveCustomization_Click(object sender, EventArgs e)
        {
            if (_selectedCoffee != null)
            {
                var item = _cart.Items.FirstOrDefault(i => i.Name == _selectedCoffee);
                if (item != null)
                {
                    item.Size = comboBoxSize.SelectedItem.ToString();
                    item.AddOns.Clear();
                    if (checkBoxSoyMilk.Checked) item.AddOns.Add("Soy Milk");
                    if (checkOatBoxMilk.Checked) item.AddOns.Add("Oat Milk");
                    if (checkBoxNoSugar.Checked) item.AddOns.Add("No Sugar");

                    // Adjust the price based on size and add-ons
                    item.Price = item.BasePrice;
                    if (checkBoxSoyMilk.Checked || checkOatBoxMilk.Checked)
                    {
                        item.Price += 2; // Price increases by $2 for soy milk or oat milk
                    }
                    if (item.Size == "Medium")
                    {
                        item.Price += 2; // Price increases by $2 for medium size
                    }
                    else if (item.Size == "Large")
                    {
                        item.Price += 3; // Price increases by $3 for large size
                    }

                    LoadCartItems();
                }
            }
        }

        private void buttonCheckout_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Order successful! Thank you for your purchase.", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the application
            Application.Exit();
        }
    }
}

