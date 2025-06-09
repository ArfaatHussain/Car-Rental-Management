using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
namespace Car_Rental_Management
{
    public partial class ViewBookings : Form
    {
        public ViewBookings()
        {
            InitializeComponent();
        }

        private void displayBookings()
        {
            MySqlConnection connection = new MySqlConnection(GlobalData.connectionString);

            // Fetching all the bookings which are pending 0 = pending, 1 = approved
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
                        INNER JOIN Customers AS cust ON b.customerId = cust.id
                        where b.status = 0";

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
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
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void ViewBookings_Load(object sender, EventArgs e)
        {
            displayBookings();
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int bookingId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string status = selectedRow.Cells["status"].Value.ToString();

                MySqlConnection connection = new MySqlConnection(GlobalData.connectionString);
                string query = "UPDATE Bookings SET status = @status WHERE id = @bookingId";
                  try
                    {
                     
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@status", 1);
                        command.Parameters.AddWithValue("@bookingId", bookingId);

                        int rowsAffected = command.ExecuteNonQuery();
                     
                        if(rowsAffected == 0){
                            MyDialogBox.showErrorMessage("Error approving booking.");
                            return;
                        }
                        displayBookings();

                    }
                    catch (Exception ex)
                    {
                        MyDialogBox.showErrorMessage("Error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MyDialogBox.showErrorMessage("Please select a booking to approve.");
                }

            }

        private void rejectBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int bookingId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                MySqlConnection connection = new MySqlConnection(GlobalData.connectionString);
                connection.Open();
                string query = "DELETE FROM Bookings where id = @bookingId";

                MySqlCommand command = new MySqlCommand(query,connection);
                command.Parameters.AddWithValue("@bookingId",bookingId);

                int rowsAffected = command.ExecuteNonQuery();
               
                if(rowsAffected == 0){
                    MyDialogBox.showErrorMessage("Error rejecting booking.");
                    return;
                }
                connection.Close();

                displayBookings();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new AdminConsole().Show();
            this.Hide();
        }
    }
}
