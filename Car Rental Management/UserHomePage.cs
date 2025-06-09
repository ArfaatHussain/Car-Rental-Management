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
    public partial class UserHomePage : Form
    {
        int customerId;
        string customerName;
        string customerEmail;
        public UserHomePage()
        {
            InitializeComponent();
        }
        public UserHomePage(int customerId, string customerName, string customerEmail)
        {
            InitializeComponent();
            this.customerName = customerName;
            this.customerId = customerId;
            this.customerEmail = customerEmail;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }

        private void UserHomePage_Load(object sender, EventArgs e)
        {
            nameLabel.Text = customerName;
            emailLabel.Text = customerEmail;
            MySqlConnection connection = new MySqlConnection(GlobalData.connectionString);
            connection.Open();

            string getAvailableCarsQuery = "SELECT * FROM cars WHERE available = @available ";
            MySqlCommand command = new MySqlCommand(getAvailableCarsQuery, connection);

            command.Parameters.AddWithValue("@available",1);

            MySqlDataReader reader = command.ExecuteReader();

            DataTable availableCarsTable = new DataTable();

            availableCarsTable.Columns.Add("id", typeof(int));
            availableCarsTable.Columns.Add("make", typeof(string));
            availableCarsTable.Columns.Add("model", typeof(string));
            availableCarsTable.Columns.Add("year", typeof(int));
            availableCarsTable.Columns.Add("pricePerDay", typeof(float));
            availableCarsTable.Columns.Add("available", typeof(int));

            while (reader.Read())
            {
                DataRow row = availableCarsTable.NewRow();
                row["id"] = reader["id"];
                row["model"] = reader["model"];
                row["year"] = reader["year"];
                row["make"] = reader["make"];
                row["pricePerDay"] = reader["pricePerDay"];
                availableCarsTable.Rows.Add(row);
            }

            dataGridView1.DataSource = availableCarsTable;
            dataGridView1.Columns["id"].HeaderText = "Car ID";
            dataGridView1.Columns["make"].HeaderText = "Make";
            dataGridView1.Columns["model"].HeaderText = "Model";
            dataGridView1.Columns["year"].HeaderText = "Year";
            dataGridView1.Columns["pricePerDay"].HeaderText = "Rent Per Day";


            connection.Close();

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            searchComboBox.SelectedIndex = -1;
        }
    }
}
