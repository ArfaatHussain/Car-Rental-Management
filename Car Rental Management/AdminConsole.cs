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
    public partial class AdminConsole : Form
    {
        public AdminConsole()
        {
            InitializeComponent();
        }

        private void displayCars()
        {
            MySqlConnection connection = new MySqlConnection(GlobalData.connectionString);
            string query = "SELECT * FROM cars;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
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
            new AddCar().Show();
            this.Hide();

        }

        private void viewBookingBtn_Click(object sender, EventArgs e)
        {
            new ViewBookings().Show();
            this.Hide();
        }

        private void viewPaymentBtn_Click(object sender, EventArgs e)
        {
            new ViewPayments().Show();
            this.Hide();
        }

        private void AdminConsole_Load(object sender, EventArgs e)
        {
            displayCars();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0){
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt16(selectedRow.Cells["id"].Value);
                string make = selectedRow.Cells["make"].Value.ToString();
                string model = selectedRow.Cells["model"].Value.ToString();
                int year =  Convert.ToInt16(selectedRow.Cells["year"].Value);
                double pricePerDay = Convert.ToDouble(selectedRow.Cells["pricePerDay"].Value);
                int available = Convert.ToInt16(selectedRow.Cells["available"].Value);

                new EditCar(id,make,model,year,pricePerDay,available).Show();
                this.Hide();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0){
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int carId = Convert.ToInt16(selectedRow.Cells["id"].Value);

                MySqlConnection connection = new MySqlConnection(GlobalData.connectionString);
                connection.Open();
                string query = "DELETE FROM Cars WHERE id = @id";

                MySqlCommand command = new MySqlCommand(query,connection);
                command.Parameters.AddWithValue("@id",carId);

                int rowsAffected = command.ExecuteNonQuery();

                if(rowsAffected == 0){

                    MyDialogBox.showErrorMessage("Error Deleting car.");
                    return;
                }

                displayCars();

               
            }
        }

    }
}
