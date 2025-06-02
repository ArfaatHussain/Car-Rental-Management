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
    public partial class ViewPayments : Form
    {
        private DataTable initialData;
        public ViewPayments()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new AdminConsole().Show();
            this.Hide();
        }

        private void ViewPayments_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(GlobalData.connectionString);

            string query = @"SELECT  p.id AS id,
                            cust.name AS customerName,
                            c.model AS carModel, 
                            p.amount AS amount,
                            p.paymentDate AS paymentDate, 
                            p.paymentStatus AS paymentStatus           
                            FROM Payments AS p
                            INNER JOIN Bookings AS b ON p.bookingId = b.id
                            INNER JOIN Customers AS cust ON cust.id = b.customerId
                            INNER JOIN Cars AS c ON c.id = b.carId
                            ";

            SqlCommand command = new SqlCommand(query,connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            initialData = new DataTable();

            adapter.Fill(initialData);


            dataGridView1.DataSource = initialData;

            dataGridView1.Columns["id"].HeaderText = "Payment ID";
            dataGridView1.Columns["customerName"].HeaderText = "Customer Name";
            dataGridView1.Columns["carModel"].HeaderText = "Car Model";
            dataGridView1.Columns["paymentDate"].HeaderText = "Payment Date";
            dataGridView1.Columns["paymentStatus"].HeaderText = "Payment Status";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string filter = string.Empty;
            if (comboBox1.SelectedItem.ToString() == "Paid only")
            {
                filter = "paymentStatus = 1";
            }
            else if (comboBox1.SelectedItem.ToString() == "Pending only")
            {
                filter = "paymentStatus = 0";
            }

            DataRow[] filteredRows = initialData.Select(filter);

            DataTable filteredData = initialData.Clone();
            foreach (DataRow row in filteredRows)
            {
                filteredData.ImportRow(row);
            }

            dataGridView1.DataSource = filteredData;
        
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = initialData;
            comboBox1.SelectedIndex = -1;
        }
    }
}
