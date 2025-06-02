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
    public partial class EditCar : Form
    {
        private int id;
        public EditCar()
        {
            InitializeComponent();
        }
        public EditCar(int id,string make, string model, int year, double pricePerDay, int available)
        {
            InitializeComponent();
            this.id = id;
            populateInputs(make,  model,  year,  pricePerDay,  available);
        }

        private void populateInputs(string make, string model, int year, double pricePerDay, int available)
        {
            makeTextBox.Text = make;
            modelTextBox.Text = model;
            yearTextBox.Text = Convert.ToString(year);
            pricePerDayTextBox.Text = Convert.ToString(pricePerDay);
            if (available == 1)
            {
                r1.Checked = true;
            }
            else
            {
                r2.Checked = true;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new AdminConsole().Show();
            this.Hide();
        }

        private void EditCar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            emptyInputs();
        }

        private void emptyInputs()
        {
            makeTextBox.Text = "";
            modelTextBox.Text = "";
            yearTextBox.Text = "";
            pricePerDayTextBox.Text = "";
            r1.Checked = false;
            r2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string make = makeTextBox.Text;
            string model = modelTextBox.Text;
            int year = Convert.ToInt16(yearTextBox.Text);
            double pricePerDay = Convert.ToDouble(pricePerDayTextBox.Text);
            int available = 0;
            if (r1.Checked)
            {
                available = 1;
            }
            SqlConnection connection = new SqlConnection(GlobalData.connectionString);

            connection.Open();

            string query = @"UPDATE Cars
                            SET make = @make,
                            model = @model,
                            year = @year,
                            pricePerDay = @pricePerDay,
                            available = @available
                            WHERE id = @id";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@id",this.id);
            command.Parameters.AddWithValue("@make", make);
            command.Parameters.AddWithValue("@model", model);
            command.Parameters.AddWithValue("@year", year);
            command.Parameters.AddWithValue("@pricePerDay", pricePerDay);
            command.Parameters.AddWithValue("@available", available);

            int rowsAffected = command.ExecuteNonQuery();
            if(rowsAffected == 0){
                MyDialogBox.showErrorMessage("Error updating Car");
                return;
            }

        }
    }
}
