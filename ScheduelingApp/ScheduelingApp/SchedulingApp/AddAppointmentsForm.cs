using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApp
{
    public partial class AddAppointmentForm : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=client_schedule;User ID=sqlUser;Password=Passw0rd!;Pooling=false;";
        private AppointmentsForm _parentForm;
        
        public AddAppointmentForm(AppointmentsForm parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            dateTimePicker.Value = _parentForm.MonthDayCalendar.SelectionStart;
            PopulateCustomers();
            PopulateEndTimeComboBox();
            PopulateStartTimeComboBox();
        }

        private void PopulateCustomers()
        {
            string query = "SELECT customerName FROM customer";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        CustomerNameTextBox.Items.Clear();

                        while (reader.Read())
                        {
                            string customerName = reader.GetString("customerName");
                            CustomerNameTextBox.Items.Add(customerName);
                        }
                        connection.Close();
                    }
                }
            }
        }

        private void PopulateStartTimeComboBox()
        {
            TimeZoneInfo estTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;

            DateTime estStartTime = new DateTime(1, 1, 1, 9, 0, 0);
            DateTime estEndTime = new DateTime(1, 1, 1, 17, 0, 0);

            StartTimeComboBox.Items.Clear();

            for (DateTime currentTime = estStartTime; currentTime <= estEndTime; currentTime = currentTime.AddMinutes(30))
            {
                DateTime localTime = TimeZoneInfo.ConvertTime(currentTime, estTimeZone, localTimeZone);
                StartTimeComboBox.Items.Add(localTime.ToString("hh:mm tt"));
            }

            if (StartTimeComboBox.Items.Count > 0)
            {
                StartTimeComboBox.SelectedIndex = 0;
            }
        }

        private void PopulateEndTimeComboBox()
        {
            TimeZoneInfo estTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;

            DateTime estStartTime = new DateTime(1, 1, 1, 9, 0, 0);
            DateTime estEndTime = new DateTime(1, 1, 1, 17, 0, 0);

            EndTimeComboBox.Items.Clear();

            for (DateTime currentTime = estStartTime; currentTime <= estEndTime; currentTime = currentTime.AddMinutes(30))
            {
                DateTime localTime = TimeZoneInfo.ConvertTime(currentTime, estTimeZone, localTimeZone);
                EndTimeComboBox.Items.Add(localTime.ToString("hh:mm tt"));
            }

            if (EndTimeComboBox.Items.Count > 0)
            {
                EndTimeComboBox.SelectedIndex = 0;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int GetCustomerId(string customerName)
        {            
            int customerId = -1;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT customerId FROM customer WHERE customerName = @customerName";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@customerName", customerName);

                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            customerId = Convert.ToInt32(result);
                        }
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving customerId: " + ex.Message);
                }
            }

            return customerId;
        }

        private void pushToDatabase()
        {
            string customerName = CustomerNameTextBox.Text;
            string type = AppointmentTypeTextBox.Text;
            DateTime selectedDate = dateTimePicker.Value;
            string timeStart = StartTimeComboBox.Text;
            string timeEnd = EndTimeComboBox.Text;
            

            using MySqlConnection connect = new MySqlConnection(connectionString);
            {
                try
                {
                    connect.Open();
                    DateTime startDateTime;
                    DateTime endDateTime;
                    if (!DateTime.TryParseExact(timeStart, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime parsedTimeStart))
                    {
                        MessageBox.Show("Invalid time format! Please enter a valid time.");
                        return;
                    }

                    if (!DateTime.TryParseExact(timeEnd, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime parsedTimeEnd))
                    {
                        MessageBox.Show("Invalid time format! Please enter a valid time.");
                        return;
                    }

                    startDateTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, parsedTimeStart.Hour, parsedTimeStart.Minute, 0, DateTimeKind.Local);
                    startDateTime = startDateTime.ToUniversalTime();

                    endDateTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, parsedTimeEnd.Hour, parsedTimeEnd.Minute, 0, DateTimeKind.Local);
                    endDateTime = endDateTime.ToUniversalTime();

                    if (startDateTime >= endDateTime)
                    {
                        MessageBox.Show("End Time must be after Start Time.");
                        return;
                    }

                    int customerId = GetCustomerId(customerName);
                    if (customerId == -1)
                    {
                        MessageBox.Show("Customer not found in the database. Please add the customer before scheduling an appointment.");
                        return;
                    }

                    string title = "not needed";
                    string location = "not needed";
                    string description = "not needed";
                    string contact = "not needed";
                    string url = "not needed";
                    DateTime createDate = DateTime.Now;

                    int userId = SignInForm.CurrentUserId;
                    string? createdBy = SignInForm.CurrentUserName;
                    string? lastUpdateBy = SignInForm.CurrentUserName;

                    string query = @"
                        INSERT INTO 
                            appointment (customerId, title, description, location, contact, type, url, start, end, createDate, userId, createdBy, lastUpdate, lastUpdateBy)
                        VALUES 
                            (@customerId, @title, @description, @location, @contact, @type, @url, @start, @end, @createDate, @userId, @createdBy, @lastUpdate, @lastUpdateBy)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@customerId", customerId);
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@location", location);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@url", url);
                        cmd.Parameters.AddWithValue("@start", startDateTime);
                        cmd.Parameters.AddWithValue("@end", endDateTime);
                        cmd.Parameters.AddWithValue("@createDate", createDate);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@createdBy", createdBy);
                        cmd.Parameters.AddWithValue("@lastUpdate", createDate);
                        cmd.Parameters.AddWithValue("@lastUpdateBy", lastUpdateBy);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Appointment saved successfully!");
                        _parentForm.RefreshAppointments();
                        connect.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving appointment: " + ex.Message);
                }
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDateTimeStart;
            DateTime selectedDateTimeEnd;
            DateTime selectedDate = dateTimePicker.Value;

            if (CustomerNameTextBox.Text == "" || AppointmentTypeTextBox.Text == "" || StartTimeComboBox.Text == "")
            {
                MessageBox.Show("Plese fill in all fields with a value before saving");
            }

            else
            {
                try
                {
                    string dateTimeStringStart = $"{dateTimePicker.Value:yyy-MM-dd} {StartTimeComboBox.Text}";
                    string dateTimeStringEnd = $"{dateTimePicker.Value:yyy-MM-dd} {EndTimeComboBox.Text}";
                    selectedDateTimeStart = DateTime.Parse(dateTimeStringStart);
                    selectedDateTimeEnd = DateTime.Parse(dateTimeStringEnd);
                }
                catch
                {
                    MessageBox.Show("Invalid date or time format.");
                    return;
                }

                string query = "SELECT COUNT(*) FROM appointment WHERE (@StartDateTime <= end AND @EndDateTime >= start)";

                using (var connection = new MySqlConnection(connectionString))
                {
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StartDateTime", selectedDateTimeStart);
                        command.Parameters.AddWithValue("@EndDateTime", selectedDateTimeEnd);
                        try
                        {
                            connection.Open();
                            int count = Convert.ToInt32(command.ExecuteScalar());

                            if (count > 0)
                            {
                                MessageBox.Show("An appointment already exists at this time.");
                            }
                            else if (selectedDate.DayOfWeek == DayOfWeek.Saturday || selectedDate.DayOfWeek == DayOfWeek.Sunday)
                            {
                                MessageBox.Show("Please select a day we are open between Monday-Friday. We are closed on the weekends silly.");
                                return;
                            }
                            else
                            {
                                pushToDatabase();
                                connection.Close();
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }                 
        }        
    }
}
