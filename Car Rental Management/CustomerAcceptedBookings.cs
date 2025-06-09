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
    public partial class CustomerAcceptedBookings : Form
    {
        public CustomerAcceptedBookings()
        {
            InitializeComponent();
        }
        private void displayBookings()
        {
            MySqlConnection connection = new MySqlConnection(GlobalData.connectionString);
            connection.Open();

            string query = @"SELECT 
        b.id AS bookingId,
        c.make AS carMake,
        c.model AS carModel,
        c.year AS carYear,
        c.pricePerDay AS carPricePerDay,
        b.startDate AS bookingStartDate,
        b.endDate AS bookingEndDate,
        b.amount AS bookingAmount
        FROM bookings AS b 
        INNER JOIN cars AS c ON c.id = b.carId
        WHERE customerId = @id AND status = @status AND paymentStatus = @paymentStatus";
            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", GlobalData.customerId);
            command.Parameters.AddWithValue("@status", 1);
            command.Parameters.AddWithValue("@paymentStatus", 0);

            MySqlDataReader reader = command.ExecuteReader();

            DataTable availableCarsTable = new DataTable();

            availableCarsTable.Columns.Add("bookingId", typeof(int));
            availableCarsTable.Columns.Add("carMake", typeof(string));
            availableCarsTable.Columns.Add("carModel", typeof(string));
            availableCarsTable.Columns.Add("carYear", typeof(int));
            availableCarsTable.Columns.Add("carPricePerDay", typeof(float));
            availableCarsTable.Columns.Add("bookingStartDate", typeof(string));
            availableCarsTable.Columns.Add("bookingEndDate", typeof(string));
            availableCarsTable.Columns.Add("bookingAmount", typeof(float));

            while (reader.Read())
            {
                DataRow row = availableCarsTable.NewRow();
                row["bookingId"] = reader["bookingId"];
                row["carMake"] = reader["carMake"];
                row["carModel"] = reader["carModel"];
                row["carYear"] = reader["carYear"];
                row["carPricePerDay"] = reader["carPricePerDay"];
                row["bookingStartDate"] = reader["bookingStartDate"];
                row["bookingEndDate"] = reader["bookingEndDate"];
                row["bookingAmount"] = reader["bookingAmount"];
                availableCarsTable.Rows.Add(row);
            }

            dataGridView1.DataSource = availableCarsTable;
            dataGridView1.Columns["bookingId"].HeaderText = "Car ID";
            dataGridView1.Columns["carMake"].HeaderText = "Make";
            dataGridView1.Columns["carModel"].HeaderText = "Model";
            dataGridView1.Columns["carYear"].HeaderText = "Year";
            dataGridView1.Columns["carPricePerDay"].HeaderText = "Rent Per Day";
            dataGridView1.Columns["bookingStartDate"].HeaderText = "Start Date";
            dataGridView1.Columns["bookingEndDate"].HeaderText = "End Date";
            dataGridView1.Columns["bookingAmount"].HeaderText = "Total Amount";

            connection.Close();
        }

        private void CustomerAcceptedBookings_Load(object sender, EventArgs e)
        {

            displayBookings();
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MyDialogBox.showErrorMessage("Select any Booking first!");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            int bookingId = Convert.ToInt16(row.Cells["bookingId"].Value);

            MySqlConnection conn = new MySqlConnection(GlobalData.connectionString);
            conn.Open();

            string query = "UPDATE bookings SET paymentStatus = @paymentStatus WHERE customerId = @id";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@paymentStatus", 1);
            command.Parameters.AddWithValue("@id", GlobalData.customerId);

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected == 0)
            {
                MyDialogBox.showErrorMessage("Error in checkout process.");
                return;
            }

            displayBookings();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UserHomePage().Show();
            this.Hide();
        }
    }
}
