using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Management
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (username == GlobalData.adminUsername && password == GlobalData.adminPassword)
            {
                new AdminConsole().Show();
                this.Hide();
            }
            else
            {
                MyDialogBox.showErrorMessage("Incorrect username or password. Try again.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdminConsole().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }
    }
}
