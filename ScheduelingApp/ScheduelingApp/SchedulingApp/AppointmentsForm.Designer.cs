namespace SchedulingApp
{
    partial class AppointmentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MonthDayCalendar = new MonthCalendar();
            DayTimeCalendar = new DataGridView();
            TimeColumn = new DataGridViewTextBoxColumn();
            CustomerColumn = new DataGridViewTextBoxColumn();
            ReasonColumn = new DataGridViewTextBoxColumn();
            appointmentIdColumn = new DataGridViewTextBoxColumn();
            AddButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            HomeButton = new Button();
            CalendarViewLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)DayTimeCalendar).BeginInit();
            SuspendLayout();
            // 
            // MonthDayCalendar
            // 
            MonthDayCalendar.Cursor = Cursors.Hand;
            MonthDayCalendar.Location = new Point(18, 28);
            MonthDayCalendar.MaxSelectionCount = 1;
            MonthDayCalendar.Name = "MonthDayCalendar";
            MonthDayCalendar.ScrollChange = 1;
            MonthDayCalendar.ShowTodayCircle = false;
            MonthDayCalendar.TabIndex = 0;
            // 
            // DayTimeCalendar
            // 
            DayTimeCalendar.AllowUserToAddRows = false;
            DayTimeCalendar.AllowUserToDeleteRows = false;
            DayTimeCalendar.AllowUserToResizeColumns = false;
            DayTimeCalendar.AllowUserToResizeRows = false;
            DayTimeCalendar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DayTimeCalendar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DayTimeCalendar.Columns.AddRange(new DataGridViewColumn[] { TimeColumn, CustomerColumn, ReasonColumn, appointmentIdColumn });
            DayTimeCalendar.Location = new Point(269, 18);
            DayTimeCalendar.Name = "DayTimeCalendar";
            DayTimeCalendar.ReadOnly = true;
            DayTimeCalendar.RowHeadersVisible = false;
            DayTimeCalendar.RowTemplate.Height = 26;
            DayTimeCalendar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DayTimeCalendar.Size = new Size(330, 470);
            DayTimeCalendar.TabIndex = 1;
            // 
            // TimeColumn
            // 
            TimeColumn.HeaderText = "";
            TimeColumn.Name = "TimeColumn";
            TimeColumn.ReadOnly = true;
            TimeColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // CustomerColumn
            // 
            CustomerColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerColumn.HeaderText = "Customer";
            CustomerColumn.Name = "CustomerColumn";
            CustomerColumn.ReadOnly = true;
            CustomerColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ReasonColumn
            // 
            ReasonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ReasonColumn.HeaderText = "Reason";
            ReasonColumn.Name = "ReasonColumn";
            ReasonColumn.ReadOnly = true;
            ReasonColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // appointmentIdColumn
            // 
            appointmentIdColumn.HeaderText = "appointmentId";
            appointmentIdColumn.Name = "appointmentIdColumn";
            appointmentIdColumn.ReadOnly = true;
            appointmentIdColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            appointmentIdColumn.Visible = false;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(170, 202);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(170, 231);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(75, 23);
            UpdateButton.TabIndex = 3;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(170, 260);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(170, 319);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(75, 23);
            HomeButton.TabIndex = 5;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // CalendarViewLabel
            // 
            CalendarViewLabel.AutoSize = true;
            CalendarViewLabel.Location = new Point(90, 7);
            CalendarViewLabel.Name = "CalendarViewLabel";
            CalendarViewLabel.Size = new Size(82, 15);
            CalendarViewLabel.TabIndex = 6;
            CalendarViewLabel.Text = "Calender View";
            // 
            // AppointmentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 500);
            Controls.Add(CalendarViewLabel);
            Controls.Add(HomeButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(DayTimeCalendar);
            Controls.Add(MonthDayCalendar);
            MaximumSize = new Size(627, 539);
            MinimumSize = new Size(627, 539);
            Name = "AppointmentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointments";
            ((System.ComponentModel.ISupportInitialize)DayTimeCalendar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button HomeButton;
        public DataGridView DayTimeCalendar;
        public MonthCalendar MonthDayCalendar;
        private DataGridViewTextBoxColumn TimeColumn;
        private DataGridViewTextBoxColumn CustomerColumn;
        private DataGridViewTextBoxColumn ReasonColumn;
        private DataGridViewTextBoxColumn appointmentIdColumn;
        private Label CalendarViewLabel;
    }
}