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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // Display contact information
            label1.Text = "Contact Information:\nPhone: 123-456-7890\nEmail: cafenated@cafe.com\nAddress: 350 Queen St, Auckland CBD, Auckland, 1010";


            // Display operating hours
            label2.Text = "Operating Hours:\nMonday - Friday: 8:00 AM - 8:00 PM\nSaturday - Sunday: 9:00 AM - 10:00 PM";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            form1.Show();

            Program.SwitchForm(this, form1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu form2= new Menu();
            form2.Show();

            Program.SwitchForm(this, form2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login form4 = new login();
            form4.Show();

            Program.SwitchForm(this, form4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Get input from contact form
            string name = textBox1.Text;
            string email = textBox2.Text;
            string subject = textBox3.Text;
            string message = textBox4.Text;

            // Validate form inputs (ensure required fields are filled)
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(subject) || string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Process the feedback (send email, save to file, etc.)
            string feedback = $"Name: {name}\nEmail: {email}\nSubject: {subject}\nMessage: {message}\n";

            feedbackFile(feedback);

            // Process the contact form (send email, save to database, etc.)
            // Example: MessageBox.Show("Your message has been sent. We will get back to you soon.", "Message Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Clear form fields after submission
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            // Show confirmation message
            MessageBox.Show("Thank you for your feedback!", "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
        }
        private void feedbackFile(string feedbackData)
        {
            try
            {
                // Specify the path to the feedback file
                string feedbackFilePath = @"C:\Programming02\Week 06\Feedback.txt";

                // Append the feedback to the text file
                using (StreamWriter writer = File.AppendText(feedbackFilePath))
                {
                    writer.WriteLine(feedbackData);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., file not found, permission denied)
                MessageBox.Show($"An error occurred while saving the feedback: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
