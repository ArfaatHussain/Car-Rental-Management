using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Management
{
    public partial class AddBooking : Form
    {
        string make;
        string model;
        int year;
        double pricePerDay;
        double totalAmount;
        int carId;
        public AddBooking()
        {
            InitializeComponent();
        }
        public AddBooking(int carId,string make, string model, int year, double pricePerDay)
        {
            InitializeComponent();
            this.pricePerDay = pricePerDay;
            this.make = make;
            this.model = model;
            this.year = year;
            this.carId = carId;
        }

        private void addBookingBtn_Click(object sender, EventArgs e)
        {
            string startDate = startDateTimePicker.Value.Date.ToString("yyyy-MM-dd");
            string endDate = endDateTimePicker.Value.Date.ToString("yyyy-MM-dd");
           
            int status = 0;
            int paymentStatus = 0;
            MySqlConnection conn = new MySqlConnection(GlobalData.connectionString);
            conn.Open();

            string query = "INSERT INTO bookings (carId, customerId, startDate, endDate, status, amount,paymentStatus) VALUES (@carId,@customerId,@startDate,@endDate,@status,@amount,@paymentStatus) ";

            MySqlCommand command = new MySqlCommand(query, conn);

            command.Parameters.AddWithValue("@carId",carId);
            command.Parameters.AddWithValue("@customerId", GlobalData.customerId);
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@endDate", endDate);
            command.Parameters.AddWithValue("@status", status);
            command.Parameters.AddWithValue("@amount", totalAmount);
            command.Parameters.AddWithValue("@paymentStatus", paymentStatus);

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected == 0)
            {
                MyDialogBox.showErrorMessage("Booking is not Added. Error occurred");
                return;
            }

            new UserHomePage().Show();
            this.Hide();

        }

        private void AddBooking_Load(object sender, EventArgs e)
        {
            makeTextBox.Text = this.make;
            modelTextBox.Text = this.model;
            yearTextBox.Text = Convert.ToString(this.year);
            pricePerDayTextBox.Text = Convert.ToString(this.pricePerDay);
            amountLabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = startDateTimePicker.Value;
            DateTime endDate = endDateTimePicker.Value;

            double pricePerDay = Convert.ToDouble(pricePerDayTextBox.Text);

            int numberOfDays = (endDate - startDate).Days + 1;

            if (numberOfDays <= 0)
            {
                MyDialogBox.showErrorMessage("End Date cannot be earlier than start date");
                return;
            }

            double totalPrice = numberOfDays * pricePerDay;
            this.totalAmount = totalPrice;
            amount.Text = Convert.ToString(totalPrice);


        }
    }
}
