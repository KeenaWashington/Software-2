using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchedulingApp
{
    public partial class AppointmentsForm : Form
    {
        public string connectionString = "Server=127.0.0.1;Database=client_schedule;User ID=sqlUser;Password=Passw0rd!;Pooling=false;";

        public AppointmentsForm()
        {
            InitializeComponent();

            CreateTimeSlots();
            MonthDayCalendar.DateChanged += MonthDayCalendar_DateChanged;
            DayTimeCalendar.Columns[0].HeaderText = MonthDayCalendar.SelectionStart.ToString("MMMM dd, yyyy");
            LoadAppointments(MonthDayCalendar.SelectionStart);
        }

        private void CreateTimeSlots()
        {
            // Generate time slots between 8:00 AM and 8:00 PM
            DateTime startTime = DateTime.Today.AddHours(0);
            DateTime endTime = DateTime.Today.AddHours(23.5);

            DayTimeCalendar.Rows.Clear();

            for (DateTime time = startTime; time <= endTime; time = time.AddMinutes(30))
            {
                DayTimeCalendar.Rows.Add(time.ToString("h:mm tt"), "", "");
            }
        }

        private void MonthDayCalendar_DateChanged(object? sender, DateRangeEventArgs e)
        {
            DayTimeCalendar.Columns[0].HeaderText = e.Start.ToString("MMMM dd, yyyy");
            CreateTimeSlots();
            LoadAppointments(e.Start);
        }

        public void LoadAppointments(DateTime selectedDate)
        {
            string query = @"
                SELECT 
                    a.appointmentId,
                    a.start, 
                    a.type, 
                    c.customerName 
                FROM 
                    appointment a 
                INNER JOIN 
                    customer c ON a.customerId = c.customerId 
                WHERE 
                    DATE(a.start) = @SelectedDate 
                ORDER BY 
                    a.start";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SelectedDate", selectedDate.ToString("yyyy-MM-dd"));

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            var appointments = GetAppointmentData(reader);
                            PopulateAppointmentsInGrid(appointments);
                            connection.Close();
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading appointments: {ex.Message}");
                }
            }
        }

        private static DataTable GetAppointmentData(MySqlDataReader reader)
        {
            var dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }

        private void PopulateAppointmentsInGrid(DataTable appointments)
        {
            foreach (DataRow appointment in appointments.Rows)
            {
                DateTime appointmentTime = Convert.ToDateTime(appointment["start"]);
                appointmentTime = appointmentTime.ToLocalTime();


                string appointmentType = appointment["type"]?.ToString() ?? "";
                string customerName = appointment["customerName"]?.ToString() ?? "";
                int appointmentId = Convert.ToInt32(appointment["appointmentId"]);

                foreach (DataGridViewRow row in DayTimeCalendar.Rows)
                {
                    if (row.Cells[0].Value?.ToString() == appointmentTime.ToString("h:mm tt"))
                    {
                        row.Cells[1].Value = customerName;
                        row.Cells[2].Value = appointmentType;
                        row.Cells[3].Value = appointmentId;
                        break;
                    }
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
                        connection.Close();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void RefreshAppointments()
        {
            LoadAppointments(MonthDayCalendar.SelectionStart);
        }

        private void DeleteSelection()
        {
            var selectedRow = DayTimeCalendar.CurrentRow;

            int appointmentId = Convert.ToInt32(selectedRow.Cells[3].Value);
            string newQuery = "DELETE FROM appointment WHERE appointmentId = @appointmentId";

            ExecuteNonQuery(newQuery, new MySqlParameter("@appointmentId", appointmentId));

            selectedRow.Cells[1].Value = "";
            selectedRow.Cells[2].Value = "";
            selectedRow.Cells[3].Value = null;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DayTimeCalendar.CurrentRow.Cells[3].Value == null)
            {
                MessageBox.Show("There is no appointment at this time slot, Plese select a row with an appointment and try again.");
                return;
            }

            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Delete this appointment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }

                DeleteSelection();
                MessageBox.Show("Appointment deleted successfully.");
            }            
        }

        public void HomeButton_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();

            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddAppointmentForm add = new AddAppointmentForm(this);
            add.ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (DayTimeCalendar.CurrentRow.Cells[3].Value == null)
            {
                MessageBox.Show("There isn't an appointment at the selected time, please click the appointment you want to update then try again.");
            }
            else
            {
                UpdateAppointmentForm update = new UpdateAppointmentForm(this);
                update.ShowDialog();
            }
        }
    }

}
