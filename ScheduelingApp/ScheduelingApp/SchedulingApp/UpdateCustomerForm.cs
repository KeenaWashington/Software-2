using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApp
{
    public partial class UpdateCustomerForm : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=client_schedule;User ID=sqlUser;Password=Passw0rd!;Pooling=false;";

        private CustomerRecordsForm _customerRecordsForm;
        public UpdateCustomerForm(CustomerRecordsForm customerRecords)
        {
            InitializeComponent();
            _customerRecordsForm = customerRecords;
            CustomerNameTextBox.Text = customerRecords.CustomerTable.CurrentRow.Cells["CustomerNameColumn"].Value.ToString();
            AddressTextBox.Text = customerRecords.CustomerTable.CurrentRow.Cells["AddressColumn"].Value.ToString();
            PhoneNumberTextBox.Text = customerRecords.CustomerTable.CurrentRow.Cells["PhoneNumberColumn"].Value.ToString();
        }

        private int getAddressId()
        {
            int addressId = -1;
            string address = _customerRecordsForm.CustomerTable.CurrentRow.Cells["AddressColumn"].Value?.ToString();

            string addressIdQuery = "SELECT addressID FROM address WHERE address = @address";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(addressIdQuery, connection))
                {
                    command.Parameters.AddWithValue("@address", address);
                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            addressId = Convert.ToInt32(result);
                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error retrieving AddressID: {ex.Message}");
                    }
                }
            }
            return addressId;
        }

        private void pushUpdateToAddress()
        {
            string address = AddressTextBox.Text;
            string phoneNumber = PhoneNumberTextBox.Text;
            DateTime lastUpdate = DateTime.Now;
            string lastUpdateBy = SignInForm.CurrentUserName;
            int addressId = getAddressId();

            string updateAddressQuery = @"
                    UPDATE 
                        address
                    SET 
                        address = @address,
                        phone = @phoneNumber,
                        lastUpdate = @lastUpdate,
                        lastUpdateBy = @lastUpdateBy
                    WHERE
                        addressId = @addressId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(updateAddressQuery, connection))
                {
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@lastUpdate", lastUpdate);
                    command.Parameters.AddWithValue("@lastUpdateBy", lastUpdateBy);
                    command.Parameters.AddWithValue("@addressId", addressId);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private int getCustomerId()
        {
            int customerId = -1;
            string customerName = _customerRecordsForm.CustomerTable.CurrentRow.Cells["CustomerNameColumn"].Value?.ToString();

            string customerIdQuery = "SELECT customerID FROM customer WHERE customerName = @customerName";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(customerIdQuery, connection))
                {
                    command.Parameters.AddWithValue("@customerName", customerName);
                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            customerId = Convert.ToInt32(result);
                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error retrieving CustomerID: {ex.Message}");
                    }
                }
            }
            return customerId;
        }

        private void pushUpdateToCustomer()
        {
            string customerName = CustomerNameTextBox.Text;
            int customerId = getCustomerId();
            DateTime lastUpdate = DateTime.Now;
            string lastUpdateBy = SignInForm.CurrentUserName;

            string updateCustomerQuery = @"
                    UPDATE 
                        customer 
                    SET 
                        customerName = @customerName,
                        lastUpdate = @lastUpdate,
                        lastUpdateBy = @lastUpdateBy
                    WHERE
                        customerId = @customerId";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(updateCustomerQuery, connection))
                {
                    command.Parameters.AddWithValue("@customerName", customerName);
                    command.Parameters.AddWithValue("@lastUpdate", lastUpdate);
                    command.Parameters.AddWithValue("@lastUpdateBy", lastUpdateBy);
                    command.Parameters.AddWithValue("@customerId", customerId);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event Action CustomerUpdated;
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CustomerNameTextBox.Text == "" || AddressTextBox.Text == "" || PhoneNumberTextBox.Text == "")
            {
                MessageBox.Show("Please make sure all fields are filled in before pressing save");
            }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(PhoneNumberTextBox.Text, @"^[0-9\-]+$"))
            {
                MessageBox.Show("Invalid phone number. Only numbers and dashes are allowed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                pushUpdateToAddress();
                pushUpdateToCustomer();
                MessageBox.Show("Customer Updated successful");
                CustomerUpdated?.Invoke();
                this.Close();
            }
        }
    }
}
