using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Car_Rental_Management
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UserSignup().Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            MySqlConnection connection = new MySqlConnection(GlobalData.connectionString);
            connection.Open();
            string query = "SELECT * FROM customers WHERE email = @email AND password = @password";
            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int customerId = Convert.ToInt16(reader["id"]);
                    string customerName = Convert.ToString(reader["name"]);
                    string customerEmail = Convert.ToString(reader["email"]);
                    GlobalData.customerName = customerName;
                    GlobalData.customerEmail = customerEmail;
                    GlobalData.customerId = customerId;
                    GlobalData.customerAddress = Convert.ToString(reader["address"]);
                    GlobalData.customerPhone = Convert.ToString(reader["phone"]);
                    GlobalData.customerPassword = Convert.ToString(reader["password"]);
                    new UserHomePage().Show();
                    this.Hide();
                }
            }
            else
            {
                MyDialogBox.showErrorMessage("Wrong username or password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }
    }
}
