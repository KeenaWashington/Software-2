namespace SchedulingApp
{
    partial class ReportsForm
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
            AppointmentTypeByMonthLabel = new Label();
            ScheduleByUserLabel = new Label();
            AppointmentsByDateLabel = new Label();
            TypeComboBox = new ComboBox();
            TypeLabel = new Label();
            MonthLabel = new Label();
            GenerateReport1Button = new Button();
            Report1TextBox = new TextBox();
            MonthComboBox = new ComboBox();
            DateLabel = new Label();
            DateCalendar = new MonthCalendar();
            GenerateReport2Button = new Button();
            Report2TextBox = new TextBox();
            UserComboBox = new ComboBox();
            UserLabel = new Label();
            GenerateReport3Button = new Button();
            ScheduleGrid = new DataGridView();
            DateColumn = new DataGridViewTextBoxColumn();
            TypeColumn = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            HomeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ScheduleGrid).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // AppointmentTypeByMonthLabel
            // 
            AppointmentTypeByMonthLabel.AutoSize = true;
            AppointmentTypeByMonthLabel.Location = new Point(190, 8);
            AppointmentTypeByMonthLabel.Name = "AppointmentTypeByMonthLabel";
            AppointmentTypeByMonthLabel.Size = new Size(249, 15);
            AppointmentTypeByMonthLabel.TabIndex = 0;
            AppointmentTypeByMonthLabel.Text = "Number of Appointments by Type and Month";
            // 
            // ScheduleByUserLabel
            // 
            ScheduleByUserLabel.AutoSize = true;
            ScheduleByUserLabel.Location = new Point(247, 8);
            ScheduleByUserLabel.Name = "ScheduleByUserLabel";
            ScheduleByUserLabel.Size = new Size(145, 15);
            ScheduleByUserLabel.TabIndex = 1;
            ScheduleByUserLabel.Text = "Monthly Schedule by User";
            // 
            // AppointmentsByDateLabel
            // 
            AppointmentsByDateLabel.AutoSize = true;
            AppointmentsByDateLabel.Location = new Point(220, 10);
            AppointmentsByDateLabel.Name = "AppointmentsByDateLabel";
            AppointmentsByDateLabel.Size = new Size(187, 15);
            AppointmentsByDateLabel.TabIndex = 2;
            AppointmentsByDateLabel.Text = "Number of Appointments by Date";
            // 
            // TypeComboBox
            // 
            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "Scrum", "Meeting", "Presentation", "Lunch", "Tea Time", "Magic The Gathering Game", "Yu Gi Oh Game" });
            TypeComboBox.Location = new Point(10, 48);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(190, 23);
            TypeComboBox.TabIndex = 3;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new Point(84, 30);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(31, 15);
            TypeLabel.TabIndex = 5;
            TypeLabel.Text = "Type";
            // 
            // MonthLabel
            // 
            MonthLabel.AutoSize = true;
            MonthLabel.Location = new Point(242, 30);
            MonthLabel.Name = "MonthLabel";
            MonthLabel.Size = new Size(43, 15);
            MonthLabel.TabIndex = 6;
            MonthLabel.Text = "Month";
            // 
            // GenerateReport1Button
            // 
            GenerateReport1Button.Location = new Point(333, 48);
            GenerateReport1Button.Name = "GenerateReport1Button";
            GenerateReport1Button.Size = new Size(75, 23);
            GenerateReport1Button.TabIndex = 7;
            GenerateReport1Button.Text = "Generate";
            GenerateReport1Button.UseVisualStyleBackColor = true;
            GenerateReport1Button.Click += GenerateReport1Button_Click;
            // 
            // Report1TextBox
            // 
            Report1TextBox.Location = new Point(414, 47);
            Report1TextBox.Multiline = true;
            Report1TextBox.Name = "Report1TextBox";
            Report1TextBox.Size = new Size(194, 37);
            Report1TextBox.TabIndex = 9;
            // 
            // MonthComboBox
            // 
            MonthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MonthComboBox.FormattingEnabled = true;
            MonthComboBox.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            MonthComboBox.Location = new Point(206, 48);
            MonthComboBox.Name = "MonthComboBox";
            MonthComboBox.Size = new Size(121, 23);
            MonthComboBox.TabIndex = 10;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(134, 24);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(31, 15);
            DateLabel.TabIndex = 11;
            DateLabel.Text = "Date";
            // 
            // DateCalendar
            // 
            DateCalendar.Location = new Point(37, 48);
            DateCalendar.Name = "DateCalendar";
            DateCalendar.ShowToday = false;
            DateCalendar.ShowTodayCircle = false;
            DateCalendar.TabIndex = 12;
            // 
            // GenerateReport2Button
            // 
            GenerateReport2Button.Location = new Point(312, 111);
            GenerateReport2Button.Name = "GenerateReport2Button";
            GenerateReport2Button.Size = new Size(75, 23);
            GenerateReport2Button.TabIndex = 13;
            GenerateReport2Button.Text = "Generate";
            GenerateReport2Button.UseVisualStyleBackColor = true;
            GenerateReport2Button.Click += GenerateReport2Button_Click;
            // 
            // Report2TextBox
            // 
            Report2TextBox.Location = new Point(393, 111);
            Report2TextBox.Multiline = true;
            Report2TextBox.Name = "Report2TextBox";
            Report2TextBox.Size = new Size(194, 37);
            Report2TextBox.TabIndex = 14;
            // 
            // UserComboBox
            // 
            UserComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            UserComboBox.FormattingEnabled = true;
            UserComboBox.Location = new Point(67, 41);
            UserComboBox.Name = "UserComboBox";
            UserComboBox.Size = new Size(121, 23);
            UserComboBox.TabIndex = 15;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(113, 23);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(30, 15);
            UserLabel.TabIndex = 16;
            UserLabel.Text = "User";
            // 
            // GenerateReport3Button
            // 
            GenerateReport3Button.Location = new Point(194, 41);
            GenerateReport3Button.Name = "GenerateReport3Button";
            GenerateReport3Button.Size = new Size(75, 23);
            GenerateReport3Button.TabIndex = 17;
            GenerateReport3Button.Text = "Generate";
            GenerateReport3Button.UseVisualStyleBackColor = true;
            GenerateReport3Button.Click += GenerateReport3Button_Click;
            // 
            // ScheduleGrid
            // 
            ScheduleGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            ScheduleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ScheduleGrid.Columns.AddRange(new DataGridViewColumn[] { DateColumn, TypeColumn });
            ScheduleGrid.Location = new Point(275, 42);
            ScheduleGrid.Name = "ScheduleGrid";
            ScheduleGrid.ReadOnly = true;
            ScheduleGrid.RowHeadersVisible = false;
            ScheduleGrid.Size = new Size(306, 150);
            ScheduleGrid.TabIndex = 18;
            // 
            // DateColumn
            // 
            DateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DateColumn.HeaderText = "Date and Time";
            DateColumn.Name = "DateColumn";
            DateColumn.ReadOnly = true;
            DateColumn.Resizable = DataGridViewTriState.False;
            DateColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // TypeColumn
            // 
            TypeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TypeColumn.HeaderText = "Appointment Type";
            TypeColumn.Name = "TypeColumn";
            TypeColumn.ReadOnly = true;
            TypeColumn.Resizable = DataGridViewTriState.False;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(MonthComboBox);
            panel1.Controls.Add(TypeComboBox);
            panel1.Controls.Add(TypeLabel);
            panel1.Controls.Add(MonthLabel);
            panel1.Controls.Add(GenerateReport1Button);
            panel1.Controls.Add(Report1TextBox);
            panel1.Controls.Add(AppointmentTypeByMonthLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(619, 95);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(DateCalendar);
            panel2.Controls.Add(DateLabel);
            panel2.Controls.Add(GenerateReport2Button);
            panel2.Controls.Add(Report2TextBox);
            panel2.Controls.Add(AppointmentsByDateLabel);
            panel2.Location = new Point(12, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(619, 225);
            panel2.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(ScheduleGrid);
            panel3.Controls.Add(ScheduleByUserLabel);
            panel3.Controls.Add(UserComboBox);
            panel3.Controls.Add(UserLabel);
            panel3.Controls.Add(GenerateReport3Button);
            panel3.Location = new Point(12, 344);
            panel3.Name = "panel3";
            panel3.Size = new Size(618, 201);
            panel3.TabIndex = 21;
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(555, 551);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(75, 23);
            HomeButton.TabIndex = 22;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 578);
            Controls.Add(HomeButton);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReportsForm";
            Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)ScheduleGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label AppointmentTypeByMonthLabel;
        private Label ScheduleByUserLabel;
        private Label AppointmentsByDateLabel;
        private ComboBox TypeComboBox;
        private Label TypeLabel;
        private Label MonthLabel;
        private Button GenerateReport1Button;
        private TextBox Report1TextBox;
        private ComboBox MonthComboBox;
        private Label DateLabel;
        private MonthCalendar DateCalendar;
        private Button GenerateReport2Button;
        private TextBox Report2TextBox;
        private ComboBox UserComboBox;
        private Label UserLabel;
        private Button GenerateReport3Button;
        private DataGridView ScheduleGrid;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn TypeColumn;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button HomeButton;
    }
}