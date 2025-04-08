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

namespace SchedulingApp
{
    public partial class CustomerRecordsForm : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=client_schedule;User ID=sqlUser;Password=Passw0rd!;Pooling=false;";

        public CustomerRecordsForm()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            CustomerTable.Rows.Clear();

            string query = (@"
                SELECT 
                    c.customerName, a.address, a.phone, c.customerId
                FROM 
                    customer c
                INNER JOIN 
                    address a ON c.addressId = a.addressId
                ORDER BY 
                    c.customerId");

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int rowIndex = CustomerTable.Rows.Add();

                                CustomerTable.Rows[rowIndex].Cells["CustomerNameColumn"].Value = reader["customerName"].ToString();
                                CustomerTable.Rows[rowIndex].Cells["AddressColumn"].Value = reader["address"].ToString();
                                CustomerTable.Rows[rowIndex].Cells["PhoneNumberColumn"].Value = reader["phone"].ToString();
                                CustomerTable.Rows[rowIndex].Cells["CustomerIdColumn"].Value = reader["customerId"].ToString();
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string query = (@"
                DELETE FROM
                    customer
                WHERE
                    customerId = @customerId");

            try
            {
                var selectedRow = CustomerTable.CurrentRow;
                int customerId = Convert.ToInt32(selectedRow.Cells[3].Value);


                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@customerId", customerId);

                        if (selectedRow.Cells[3].Value == null)
                        {
                            MessageBox.Show("Row is empty. Please select a row and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            command.ExecuteNonQuery();
                            LoadCustomers();
                            connection.Close();
                            MessageBox.Show("Customer Deleted");
                            return;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show("Cannot delete this customer because they have associated appointments. Please delete the appointments first.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"A database error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomer = new AddCustomerForm();

            addCustomer.CustomerAdded += LoadCustomers;

            addCustomer.ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Only the Cusomer Name, Phone Number, and Address can be Updated for database continuity reasons.");
            UpdateCustomerForm updateCustomer = new UpdateCustomerForm(this);

            updateCustomer.CustomerUpdated += LoadCustomers;

            updateCustomer.ShowDialog();

        }
    }
}
