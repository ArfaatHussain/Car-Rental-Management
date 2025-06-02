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
    public partial class ViewBookings : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Arfaat\Documents\CarRentalManagement.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        public ViewBookings()
        {
            InitializeComponent();
        }

        private void ViewBookings_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"
                        SELECT 
                            b.id AS id, 
                            cust.name AS customerName,
                            cust.email AS customerEmail,
                            cust.phone AS customerPhone,
                            cust.address AS customerAddress,
                            c.make AS carMake,
                            c.year AS carYear,
                            c.model AS carModel,
                            c.pricePerDay AS carPricePerDay,
                            b.startDate AS startDate, 
                            b.endDate AS endDate,
                            b.status AS status
                        FROM Bookings AS b
                        INNER JOIN Cars AS c ON b.carId = c.id
                        INNER JOIN Customers AS cust ON b.customerId = cust.id";

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                dataGridView1.Columns["id"].HeaderText = "Booking ID";
                dataGridView1.Columns["customerName"].HeaderText = "Customer Name";
                dataGridView1.Columns["customerEmail"].HeaderText = "Customer Email";
                dataGridView1.Columns["customerPhone"].HeaderText = "Customer Phone";
                dataGridView1.Columns["customerAddress"].HeaderText = "Customer Address";
                dataGridView1.Columns["carMake"].HeaderText = "Car Make";
                dataGridView1.Columns["carYear"].HeaderText = "Car Year";
                dataGridView1.Columns["carModel"].HeaderText = "Car Model";
                dataGridView1.Columns["carPricePerDay"].HeaderText = "Price Per Day";
                dataGridView1.Columns["startDate"].HeaderText = "Start Date";
                dataGridView1.Columns["endDate"].HeaderText = "End Date";
                dataGridView1.Columns["status"].HeaderText = "Booking Status";
            }
            catch (Exception ex)
            {
                // Handle any exceptions (e.g., SQL errors or connection issues)
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                connection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

            }

        }

        private void rejectBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
