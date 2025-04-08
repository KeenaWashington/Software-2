using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections;
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
    public partial class UpdateAppointmentForm : Form
    {
        private AppointmentsForm _parentForm;
        private string connectionString = "Server=127.0.0.1;Database=client_schedule;User ID=sqlUser;Password=Passw0rd!;Pooling=false;";

        public UpdateAppointmentForm(AppointmentsForm parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            dateTimePicker.Value = _parentForm.MonthDayCalendar.SelectionStart;
            AppointmentTypeTextBox.Text = _parentForm.DayTimeCalendar.CurrentRow.Cells["ReasonColumn"].Value.ToString();

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
                        while (reader.Read())
                        {
                            string customerName = reader.GetString("customerName");
                            CustomerNameTextBox.Items.Add(customerName);
                        }
                        connection.Close();
                        CustomerNameTextBox.Text = _parentForm.DayTimeCalendar.CurrentRow.Cells["CustomerColumn"].Value.ToString();
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

            StartTimeComboBox.Items.Clear();

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
            DateTime startDateTime;
            DateTime endDateTime;
            int appointmentId = Convert.ToInt32(_parentForm.DayTimeCalendar.CurrentRow.Cells[3].Value);
            int userId = SignInForm.CurrentUserId;
            string? createdBy = SignInForm.CurrentUserName;
            string? lastUpdateBy = SignInForm.CurrentUserName;
            DateTime lastUpdate = DateTime.Now;

            using MySqlConnection connect = new MySqlConnection(connectionString);
            {
                try
                {
                    connect.Open();
                    
                    if (!DateTime.TryParseExact(timeStart, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime parsedTime))
                    {
                        MessageBox.Show("Invalid time format! Please enter a valid time.");
                        return;
                    }

                    if (!DateTime.TryParseExact(timeEnd, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime endParsedTime))
                    {
                        MessageBox.Show("Invalid time format. Please select a valid time.");
                        return;
                    }

                    startDateTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, parsedTime.Hour, parsedTime.Minute, 0, DateTimeKind.Local);
                    startDateTime = startDateTime.ToUniversalTime();

                    endDateTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, endParsedTime.Hour, endParsedTime.Minute, 0, DateTimeKind.Local);
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

                    string query = @"
                        UPDATE appointment
                        SET
                            customerId = @customerId, 
                            type = @type, 
                            start = @start, 
                            end = @end, 
                            userId = @userId, 
                            lastUpdate = @lastUpdate, 
                            lastUpdateBy = @lastUpdateBy
                        WHERE
                            appointmentId = @appointmentId";

                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@customerId", customerId);
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@start", startDateTime);
                        cmd.Parameters.AddWithValue("@end", endDateTime);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@lastUpdate", lastUpdate);
                        cmd.Parameters.AddWithValue("@lastUpdateBy", lastUpdateBy);
                        cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Appointment saved successfully!");

                        _parentForm.RefreshAppointments();
                    }
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving appointment: " + ex.Message);
                }
            }

        }

        private void ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddRange(parameters);
                        command.ExecuteNonQuery();
                        _parentForm.RefreshAppointments();
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker.Value;
            int appointmentId = Convert.ToInt32(_parentForm.DayTimeCalendar.CurrentRow.Cells[3].Value);

            if (CustomerNameTextBox.Text == "" || AppointmentTypeTextBox.Text == "" || StartTimeComboBox.Text == "")
            {
                MessageBox.Show("Plese fill in all fields with a value before saving");
            }
            else
            {
                try
                {
                    if (!DateTime.TryParseExact(StartTimeComboBox.Text, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime parsedTime))
                    {
                        MessageBox.Show("Invalid time format. Please select a valid time.");
                        return;
                    }

                    if (!DateTime.TryParseExact(EndTimeComboBox.Text, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime endParsedTime))
                    {
                        MessageBox.Show("Invalid time format. Please select a valid time.");
                        return;
                    }
                    DateTime localDateTimeStart = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, parsedTime.Hour, parsedTime.Minute, 0, DateTimeKind.Local);
                    DateTime selectedDateTimeStart = localDateTimeStart.ToUniversalTime();

                    DateTime localDateTimeEnd = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, endParsedTime.Hour, endParsedTime.Minute, 0, DateTimeKind.Local);
                    DateTime selectedDateTimeEnd = localDateTimeEnd.ToUniversalTime();

                    string updateQuery = @"
                        SELECT COUNT(*) 
                        FROM appointment
                        WHERE (@StartDateTime <= end AND @EndDateTime >= start)
                        AND appointmentId != @appointmentId";

                    using (var connection = new MySqlConnection(connectionString))
                    {
                        using (var command = new MySqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@StartDateTime", selectedDateTimeStart);
                            command.Parameters.AddWithValue("@EndDateTime", selectedDateTimeEnd);
                            command.Parameters.AddWithValue("@appointmentId", appointmentId);

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
                                    _parentForm.DayTimeCalendar.CurrentRow.Cells[1].Value = "";
                                    _parentForm.DayTimeCalendar.CurrentRow.Cells[2].Value = "";
                                    _parentForm.DayTimeCalendar.CurrentRow.Cells[3].Value = null;
                                    _parentForm.LoadAppointments(_parentForm.MonthDayCalendar.SelectionStart);
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
                catch
                {
                    MessageBox.Show("Invalid date or time format.");
                    return;
                }
            }            
        }
    }
}
