using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cafe_Studio02
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // Registration successful
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            login form= new login();
            form.Show();

            Program.SwitchForm(this, form);
            // Save registration data to a file
            SaveRegistrationData(name.Text, agetxt.Text, mailtxt.Text, contacttxt.Text, username.Text, password.Text);
        }

        private void SaveRegistrationData(string name, string age, string email, string contact, string username, string password)
        {
            string filePath = "userinfo.txt"; // File path where registration data will be saved

            try
            {
                // Create a new CSV file or append to an existing one
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    // Format the data as CSV and write it to the file
                    sw.WriteLine($"{name},{age},{email},{contact},{username},{password}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving registration data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Add your code here
        }

        private void agetxt_TextChanged(object sender, EventArgs e)
        {
            // Add your code here
        }

        private void mailtxt_TextChanged(object sender, EventArgs e)
        {
            // Add your code here
        }

        private void contacttxt_TextChanged(object sender, EventArgs e)
        {
            // Add your code here
        }

        private void addresstxt_TextChanged(object sender, EventArgs e)
        {
            // Add your code here
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
            // Add your code here
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            // Add your code here
        }

        private void confirmtxt_TextChanged(object sender, EventArgs e)
        {
            // Add your code here
        }

        private void Register_Load(object sender, EventArgs e)
        {
            // Add your code here
        }

        private void label9_Click(object sender, EventArgs e)
        {
            // Add your code here
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Add your code here
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // Add your code here
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Add your code here
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Add your code here
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Add your code here
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Add your code here
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Add your code here
        }

    }
}
