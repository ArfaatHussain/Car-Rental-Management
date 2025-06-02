using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_Rental_Management
{
    public partial class AdminConsole : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Arfaat\Documents\CarRentalManagement.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        public AdminConsole()
        {
            InitializeComponent();
        }

        private void displayCars()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM cars;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].HeaderText = "Car ID";
            dataGridView1.Columns["make"].HeaderText = "Car Make";
            dataGridView1.Columns["model"].HeaderText = "Car Model";
            dataGridView1.Columns["year"].HeaderText = "Manufacturing Year";
            dataGridView1.Columns["pricePerDay"].HeaderText = "Rental Price Per Day";
            dataGridView1.Columns["available"].HeaderText = "Availability";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"INSERT INTO Bookings (startDate, endDate, status, carId, customerId)
                            VALUES
                            ('2025-06-01', '2025-06-05', 0, 1, 1),
                            ('2025-06-02', '2025-06-06', 1, 2, 2),
                            ('2025-06-10', '2025-06-15', 0, 3, 3),
                            ('2025-06-12', '2025-06-16', 1, 4, 4),
                            ('2025-06-20', '2025-06-25', 0, 5, 5);
";
            connection.Open();
            SqlCommand command = new SqlCommand(query,connection);
            command.ExecuteNonQuery();
            connection.Close();

        }

        private void viewBookingBtn_Click(object sender, EventArgs e)
        {
            new ViewBookings().Show();
            this.Hide();
        }

        private void viewPaymentBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
