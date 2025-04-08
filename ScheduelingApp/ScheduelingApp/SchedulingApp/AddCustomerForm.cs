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
    public partial class AddCustomerForm : Form
    {
        string connectionString = "Server=127.0.0.1;Database=client_schedule;User ID=sqlUser;Password=Passw0rd!;Pooling=false;";

        public AddCustomerForm()
        {
            InitializeComponent();
        }
        private int GetCityId(string city)
        {
            int cityId = -1;

            string queryCityId = "SELECT cityId FROM city WHERE city = @city";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(queryCityId, connection))
                {
                    command.Parameters.AddWithValue("@city", city);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            cityId = Convert.ToInt32(result);
                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error retrieving CityID: {ex.Message}");
                    }
                }
            }
            return cityId;
        }


        private void pushAddressToDatabase()
        {
            string address = AddressTextBox.Text.Trim();
            string address2 = " ";
            string city = CityComboBox.Text;
            int cityId = GetCityId(city);
            int postalCode = Convert.ToInt32(PostalCodeTextBox.Text.Trim());
            string phone = PhoneNumberTextBox.Text.Trim();

            DateTime createDate = DateTime.Now;
            string createdBy = SignInForm.CurrentUserName;
            DateTime lastUpdate = DateTime.Now;
            string lastUpdateBy = SignInForm.CurrentUserName;

            string queryAddress = @"
                    INSERT INTO
                        address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy)
                    VALUES
                        (@address, @address2, @cityId, @postalCode, @phone, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)
                    ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(queryAddress, connection);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@address2", address2);
                command.Parameters.AddWithValue("@cityId", cityId);
                command.Parameters.AddWithValue("@postalCode", postalCode);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@createDate", createDate);
                command.Parameters.AddWithValue("@createdBy", createdBy);
                command.Parameters.AddWithValue("@lastUpdate", lastUpdate);
                command.Parameters.AddWithValue("@lastUpdateBy", lastUpdateBy);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private int GetaddressId(string address)
        {
            int addressId = -1;

            string queryAddressId = "SELECT addressId FROM address WHERE address = @address";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(queryAddressId, connection))
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

        private void pushCustomerToDatabase()
        {
            string customerName = CustomerNameTextBox.Text.Trim();
            string address = AddressTextBox.Text.Trim();
            int addressId = GetaddressId(address);
            int active = 1;

            DateTime createDate = DateTime.Now;
            string createdBy = SignInForm.CurrentUserName;
            DateTime lastUpdate = DateTime.Now;
            string lastUpdateBy = SignInForm.CurrentUserName;

            string queryCustomer = @"
                INSERT INTO 
                    customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy)
                VALUES
                    (@customerName, @addressId, @active, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)
                ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(queryCustomer, connection);
                command.Parameters.AddWithValue("@customerName", customerName);
                command.Parameters.AddWithValue("@addressId", addressId);
                command.Parameters.AddWithValue("@active", active);
                command.Parameters.AddWithValue("@createDate", createDate);
                command.Parameters.AddWithValue("@createdBy", createdBy);
                command.Parameters.AddWithValue("@lastUpdate", lastUpdate);
                command.Parameters.AddWithValue("@lastUpdateBy", lastUpdateBy);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event Action CustomerAdded;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CustomerNameTextBox.Text == "" || AddressTextBox.Text == "" || PostalCodeTextBox.Text == "" || PhoneNumberTextBox.Text == "" || CityComboBox.Text == "")
            {
                MessageBox.Show("Please make sure all fields are filled in before pressing save");
            }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(PhoneNumberTextBox.Text, @"^[0-9\-]+$"))
            {
                MessageBox.Show("Invalid phone number. Only numbers and dashes are allowed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                pushAddressToDatabase();
                pushCustomerToDatabase();
                CustomerAdded?.Invoke();
                MessageBox.Show("Customer Saved successfully");
                this.Close();
            }
        }
    }
}
