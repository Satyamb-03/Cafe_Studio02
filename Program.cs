using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Studio02
{
    static class Program
    {
        private static Form mainForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the main form (Form1 initially)
            mainForm = new Form1();
            Application.Run(mainForm);
        }

        public static void SwitchForm(Form currentForm, Form newForm)
        {
            // Hide the current form
            currentForm.Hide();

            // Show the new form
            newForm.FormClosed += (s, args) => currentForm.Show(); // Show the previous form when the new form is closed
            newForm.Show();
        }
    }
}
