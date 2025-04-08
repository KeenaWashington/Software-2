using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SchedulingApp
{
    public partial class ReportsForm : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=client_schedule;User ID=sqlUser;Password=Passw0rd!;Pooling=false;";

        public ReportsForm()
        {
            InitializeComponent();

            PutAllUsersInComboBox();
        }

        public int GetMonth(string month)
        {
            try
            {
                DateTime monthValue = DateTime.ParseExact(month, "MMMM", System.Globalization.CultureInfo.InvariantCulture);
                return monthValue.Month;
            }
            catch
            {
                return 0;
            }
        }

        private void GenerateReport1Button_Click(object sender, EventArgs e)
        {
            int month = GetMonth(MonthComboBox.Text);
            string type = TypeComboBox.Text;

            string query = @"
                SELECT COUNT(*)
                FROM
                    appointment
                WHERE 
                    type = @type
                AND
                    MONTH(start) = @month";

            if (type == "" || month == 0)
            {
                MessageBox.Show("You must select an option in the type and month boxes before you can generate a report.");
                return;
            }

            else
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@type", type);
                        command.Parameters.AddWithValue("@month", month);

                        var result = command.ExecuteScalar();

                        Func<string, string> report1 = (appointmentType) => $"There are {result} {appointmentType} appointment(s) in {MonthComboBox.Text}";
                        Report1TextBox.Text = report1(type);
                        connection.Close();
                    }
                }
            }
        }

        private void GenerateReport2Button_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = DateCalendar.SelectionStart;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");

            string query = @"
                SELECT COUNT(*)
                FROM 
                    appointment
                WHERE
                    DATE(start) = @formattedDate";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@formattedDate", formattedDate);
                    var result = Convert.ToInt32(command.ExecuteScalar());

                    Func<int, string> report2 = count => $"There is {count} appointment(s) on this date";

                    Report2TextBox.Text = report2(result);
                    connection.Close();
                }
            }
        }

        private void PutAllUsersInComboBox()
        {
            string query = @"
                SELECT 
                    userName
                FROM 
                    user";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        UserComboBox.Items.Clear();

                        while (reader.Read())
                        {
                            string userName = reader.GetString("userName");
                            UserComboBox.Items.Add(userName);
                        }
                        connection.Close();
                    }
                }
            }
        }

        private void GenerateReport3Button_Click(object sender, EventArgs e)
        {
            string user = UserComboBox.Text;

            string query = @"
                SELECT 
                    a.start, 
                    a.type
                FROM
                    appointment a
                INNER JOIN
                    user u ON a.userId = u.userId
                WHERE 
                    u.userName = @user";

            if (user == "")
            {
                MessageBox.Show("Please select a User before you generate your report");
                return;
            }

            else
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@user", user);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            ScheduleGrid.Rows.Clear();

                            Action<DateTime, string> addRowToGrid = (date, type) =>
                            {
                                ScheduleGrid.Rows.Add(date, type);
                            };

                            while (reader.Read())
                            {
                                DateTime appointmentDate = reader.GetDateTime("start");
                                string appointmentType = reader.GetString("type");

                                addRowToGrid(appointmentDate, appointmentType);
                            }
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Close();
        }
    }
}
