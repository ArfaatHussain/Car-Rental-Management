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
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string make = makeTextBox.Text;
            string model = modelTextBox.Text;
            int year = Convert.ToInt16(yearTextBox.Text);
            double pricePerDay = Convert.ToDouble(pricePerDayTextBox.Text);
            int available = 0;
            if(r1.Checked){
                available = 1;
            }

            SqlConnection connection = new SqlConnection(GlobalData.connectionString);
            connection.Open();
            string query = @"INSERT INTO Cars (make,model,year,pricePerDay,available)
            VALUES (@make,@model,@year,@pricePerDay,@available)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@make",make);
            command.Parameters.AddWithValue("@model", model);
            command.Parameters.AddWithValue("@year", year);
            command.Parameters.AddWithValue("@pricePerDay", pricePerDay);
            command.Parameters.AddWithValue("@available", available);

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected == 0) {
                MyDialogBox.showErrorMessage("Car is not added.");
                return;
            }
            emptyInputs();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new AdminConsole().Show();
            this.Hide();
        }

        private void emptyInputs() {
            makeTextBox.Text = "";
            modelTextBox.Text = "";
            yearTextBox.Text = "";
            pricePerDayTextBox.Text = "";
            r1.Checked = false;
            r2.Checked = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            emptyInputs();
        }
    }
}
