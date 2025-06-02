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

            string query = @"
                            INSERT INTO Cars (make, model, year, pricePerDay, available)
                            VALUES
                                ('Toyota', 'Corolla', 2020, 35.00, 1),
                                ('Honda', 'Civic', 2021, 40.00, 1),
                                ('Ford', 'Focus', 2019, 30.00, 0),
                                ('Chevrolet', 'Malibu', 2018, 45.00, 0),
                                ('BMW', 'X5', 2022, 80.00, 1),
                                ('Audi', 'A4', 2020, 60.00, 0),
                                ('Hyundai', 'Elantra', 2021, 38.00, 1),
                                ('Mercedes', 'E-Class', 2019, 75.00, 0),
                                ('Nissan', 'Altima', 2020, 42.00, 1),
                                ('Volkswagen', 'Passat', 2021, 50.00, 1);
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
