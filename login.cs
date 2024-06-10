using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Studio02
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            passwordtxt.PasswordChar = '*';
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = passwordtxt.Text;

            if (IsLoginValid(username, password))
            {
                // Check if username or password is empty
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method to prevent further execution
                }

                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Proceed with further actions after successful login

                Menu form = new Menu();
                form.Show();

                Program.SwitchForm(this,form);
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsLoginValid(string username, string password)
        {
            string filePath = "userinfo.txt"; // File path where registration data is stored

            try
            {
                // Read each line in the file
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Split the line into fields
                        string[] fields = line.Split(',');

                        // Check if username and password match
                        if (fields.Length >= 6 && fields[4] == username && fields[5] == password)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading registration data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Open the Register form
            Register registerForm = new Register();
            registerForm.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
