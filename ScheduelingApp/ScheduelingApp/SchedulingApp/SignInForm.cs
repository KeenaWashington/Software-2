using MySql.Data.MySqlClient;
using System.Globalization;
using System.Net;
using System.Resources;

namespace SchedulingApp
{
    public partial class SignInForm : Form
    {
        string connectionString = "Server=127.0.0.1;Database=client_schedule;User ID=sqlUser;Password=Passw0rd!;Pooling=false;";

        public static string CurrentUserName;
        public static int CurrentUserId;        

        ResourceManager rm;
        public SignInForm()
        {
            InitializeComponent();

            rm = new ResourceManager("SchedulingApp.Resources.Messages", typeof(SignInForm).Assembly);

            if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "es")
            {
                this.Text = "Iniciar sesión";
                UsernameLabel.Text = "Nombre de usuario";
                PasswordLabel.Text = "Contraseña";
                LoginButton.Text = "Acceso";
            }
        }

        private void ShowMessage(string key)
        {
            string popMessage = rm.GetString(key, Thread.CurrentThread.CurrentCulture) ?? "Null Field";
            MessageBox.Show(popMessage);
        }

        private void GetUpcomingAppointmentInformation()
        {
            int currentUser = CurrentUserId;

            string query = @"
                SELECT 
                    c.customerName, a.type, a.start 
                FROM 
                    appointment a
                INNER JOIN
                    customer c ON a.customerId = c.customerID
                WHERE 
                    a.start 
                BETWEEN 
	                NOW() 
                AND 
	                DATE_ADD(NOW(), INTERVAL 15 MINUTE) 
                AND 
                    a.userId = @currentUserId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@currentUserId", currentUser);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No Upcoming appointments.");
                            return;
                        }
                        while (reader.Read())
                        {
                            string customerName = reader["customerName"].ToString();
                            string appointmentType = reader["type"].ToString();
                            DateTime startTime = Convert.ToDateTime(reader["start"]);
                            DateTime localstartTime = startTime.ToLocalTime();
                            string justTime = localstartTime.ToString("HH:mm");

                            MessageBox.Show($"{customerName} has a {appointmentType} appointment at {justTime} in your local time.");
                        }
                        connection.Close();
                    }
                }
            }
        }

        private void LogUserLogin(string currentUserName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string logFilePath = Path.Combine(desktopPath, "Login_Log.txt");
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - User: {currentUserName}{Environment.NewLine}";

            if (File.Exists(logFilePath))
            {
                File.AppendAllText(logFilePath, logEntry);
            }
            else
            {
                File.WriteAllText(logFilePath, logEntry);
            }

            MessageBox.Show("Login logged successfully!", "Login Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string username = UsernameTextBox.Text;
                    string password = PasswordTextBox.Text;

                    string query = @"
                        SELECT 
                            userId, userName 
                        FROM 
                            user 
                        WHERE 
                            userName = @username 
                        AND 
                            password = @password";

                    
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        CurrentUserId = reader.GetInt32("userId");
                        CurrentUserName = reader.GetString("userName");
                        
                        ShowMessage("LoginSuccessful");                        
                        connection.Close();

                        LogUserLogin(CurrentUserName);
                        GetUpcomingAppointmentInformation();

                        this.Hide();

                        HomeForm main = new HomeForm();
                        main.Show();
                    }
                    else
                    {
                        ShowMessage("LoginInvalid");
                    }               
                }
                catch (MySqlException ex)
                {
                    ShowMessage("Database error" + ex.Message);
                }
            }
        }
    }
}
