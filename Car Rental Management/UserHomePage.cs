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
        DataTable initialCarData = new DataTable();

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

        private void displayCars(DataTable dataToDisplay)
        {
            dataGridView1.DataSource = dataToDisplay;
            dataGridView1.Columns["id"].HeaderText = "Car ID";
            dataGridView1.Columns["make"].HeaderText = "Make";
            dataGridView1.Columns["model"].HeaderText = "Model";
            dataGridView1.Columns["year"].HeaderText = "Year";
            dataGridView1.Columns["pricePerDay"].HeaderText = "Rent Per Day";
        }

        private void loadInitialCars()
        {
            MySqlConnection connection = new MySqlConnection(GlobalData.connectionString);
            connection.Open();

            string getAvailableCarsQuery = "SELECT * FROM cars WHERE available = @available ";
            MySqlCommand command = new MySqlCommand(getAvailableCarsQuery, connection);
            command.Parameters.AddWithValue("@available", 1);

            MySqlDataReader reader = command.ExecuteReader();

            initialCarData.Clear();  // Clear the existing data
            initialCarData.Columns.Add("id", typeof(int));
            initialCarData.Columns.Add("make", typeof(string));
            initialCarData.Columns.Add("model", typeof(string));
            initialCarData.Columns.Add("year", typeof(int));
            initialCarData.Columns.Add("pricePerDay", typeof(float));

            while (reader.Read())
            {
                DataRow row = initialCarData.NewRow();
                row["id"] = reader["id"];
                row["make"] = reader["make"];
                row["model"] = reader["model"];
                row["year"] = reader["year"];
                row["pricePerDay"] = reader["pricePerDay"];
                initialCarData.Rows.Add(row);
            }

            // Display the initial data
            displayCars(initialCarData);

            connection.Close();
        }

        private void filterCars()
        {
            // Get the filter criteria entered by the user
            string filterExpression = string.Empty;

            if (!string.IsNullOrEmpty(searchTextBox.Text))
            {
                // Check which filter the user selected
                string filterType = searchComboBox.SelectedItem?.ToString();
                if (filterType == "Year")
                {
                    filterExpression = "year<=" + Convert.ToInt16(searchTextBox.Text);
                }
                else if (filterType == "Model")
                {
                    filterExpression = "model LIKE '%" + searchTextBox.Text + "%'";
                }
                else if (filterType == "Make")
                {
                    filterExpression = "make LIKE '%" + searchTextBox.Text + "%'";
                }
                else if (filterType == "Price")
                {
                    double price = Convert.ToDouble(searchTextBox.Text);
                    filterExpression = "pricePerDay <= " + price.ToString();
                }
            }

            // Apply the filter expression
            if (!string.IsNullOrEmpty(filterExpression))
            {
                DataRow[] filteredRows = initialCarData.Select(filterExpression);
                DataTable filteredTable = initialCarData.Clone();
                foreach (DataRow row in filteredRows)
                {
                    filteredTable.ImportRow(row);
                }

                displayCars(filteredTable);  // Display filtered data
            }
        }
        private void UserHomePage_Load(object sender, EventArgs e)
        {
            nameLabel.Text = customerName;
            emailLabel.Text = customerEmail;
            loadInitialCars();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            searchComboBox.SelectedIndex = -1;
            displayCars(initialCarData);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CustomerAcceptedBookings().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CustomerPendingBookings().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MyDialogBox.showErrorMessage("Choose car first!");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int carId = Convert.ToInt16(row.Cells["id"].Value);
            string make = Convert.ToString(row.Cells["make"].Value);
            string model = Convert.ToString(row.Cells["model"].Value);
            int year = Convert.ToInt16(row.Cells["year"].Value);
            double pricePerDay = Convert.ToDouble(row.Cells["pricePerDay"].Value);

            new AddBooking(carId, make, model, year, pricePerDay).Show();
            this.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            filterCars();
        }
    }
}
