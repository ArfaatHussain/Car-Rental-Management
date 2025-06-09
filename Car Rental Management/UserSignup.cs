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
    public partial class UserSignup : Form
    {
        public UserSignup()
        {
            InitializeComponent();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string name = nameTextBox.Text;
            string password = passwordTextBox.Text;
            string address = addressTextBox.Text;
            string phone = phoneTextBox.Text;

            MySqlConnection connection = new MySqlConnection(GlobalData.connectionString);
            connection.Open();
            string query = "SELECT * FROM customers where email = @email;";
            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@email", email);

            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                MyDialogBox.showErrorMessage("User already exists with this email.");
                return;
            }
            reader.Close();

            string insertQuery = "INSERT INTO customers (name,email,password,address,phone) VALUES (@name,@customerEmail,@password,@address,@phone) ";
            MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
            insertCommand.Parameters.AddWithValue("name",name);
            insertCommand.Parameters.AddWithValue ("@password",password);
            insertCommand.Parameters.AddWithValue("@address",address);
            insertCommand.Parameters.AddWithValue("@phone",phone);
            insertCommand.Parameters.AddWithValue("@customerEmail", email);

            int rowsAffected = insertCommand.ExecuteNonQuery();
            if (rowsAffected == 0)
            {
                MyDialogBox.showErrorMessage("User not created. Error!");
            }
            else {
                connection.Close();
                new UserLogin().Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UserLogin().Show();
            this.Hide();
        }
    }
}
