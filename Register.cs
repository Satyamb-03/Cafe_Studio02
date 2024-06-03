using System;
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
            // Validate inputs
            if (!IsValidName(usernametxt.Text))
            {
                MessageBox.Show("Name can only contain alphabets.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidAge(agetxt.Text))
            {
                MessageBox.Show("Age must be a number up to 3 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(mailtxt.Text))
            {
                MessageBox.Show("Email must be valid and contain '@'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidContact(contacttxt.Text))
            {
                MessageBox.Show("Contact must be a number up to 12 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidUsername(usernametxt.Text))
            {
                MessageBox.Show("Username can contain letters and numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidPassword(passwordtxt.Text))
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (passwordtxt.Text != confirmtxt.Text)
            {
                MessageBox.Show("Password and Confirm Password must match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Registration successful
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Proceed with further actions, such as saving the data
        }

        private bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z]+$");
        }

        private bool IsValidAge(string age)
        {
            return Regex.IsMatch(age, @"^\d{1,3}$");
        }

        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private bool IsValidContact(string contact)
        {
            return Regex.IsMatch(contact, @"^\d{1,12}$");
        }

        private bool IsValidUsername(string username)
        {
            return Regex.IsMatch(username, @"^[a-zA-Z0-9]+$");
        }

        private bool IsValidPassword(string password)
        {
            return password.Length >= 8;
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
