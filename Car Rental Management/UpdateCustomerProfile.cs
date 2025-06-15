using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Car_Rental_Management
{
    public partial class UpdateCustomerProfile : Form
    {
        public UpdateCustomerProfile()
        {
            InitializeComponent();
            customerNameLabel.Text = GlobalData.customerName + "!";
            nameTextBox.Text = GlobalData.customerName;
            emailTextBox.Text = GlobalData.customerEmail;
            phoneTextBox.Text = GlobalData.customerPhone;
            addressTextBox.Text = GlobalData.customerAddress;
            passwordTextBox.Text = GlobalData.customerPassword;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;
            string address = addressTextBox.Text;
            string password = passwordTextBox.Text;

            MySqlConnection connection = new MySqlConnection(GlobalData.connectionString);
            connection.Open();

            string query = @"
                                UPDATE customers
                                SET name = @customerName,
                                email = @customerEmail,
                                address = @address,
                                password = @password,
                                phone = @phone
                                WHERE id = @customerID
                                ";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerName", name);
            command.Parameters.AddWithValue("@customerEmail", email);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@customerID", GlobalData.customerId);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected == 0)
            {
                MyDialogBox.showErrorMessage("Profile did not update. Failed!");
                return;
            }

            GlobalData.customerName = name;
            GlobalData.customerEmail = email;
            GlobalData.customerPhone = phone;
            GlobalData.customerAddress = address;

            new UserHomePage().Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            new UserHomePage().Show();
            this.Hide();
        }
    }
}
