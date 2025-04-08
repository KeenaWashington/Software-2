using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            AppointmentsForm appointments = new AppointmentsForm();
            appointments.Show();

            this.Close();
        }

        private void CustomerRecordsButton_Click(object sender, EventArgs e)
        {
            CustomerRecordsForm customerRecords = new CustomerRecordsForm();
            customerRecords.Show();
            this.Close();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            ReportsForm reports = new ReportsForm();
            reports.Show();
            this.Close();
        }
    }
}
