namespace SchedulingApp
{
    partial class AddAppointmentForm
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
            CustomerNameLabel = new Label();
            AppointmentTypeLabel = new Label();
            DateLabel = new Label();
            BackButton = new Button();
            SaveButton = new Button();
            dateTimePicker = new DateTimePicker();
            label1 = new Label();
            AppointmentTypeTextBox = new ComboBox();
            label2 = new Label();
            EndTimeComboBox = new ComboBox();
            StartTimeComboBox = new ComboBox();
            StartTimeLabel = new Label();
            CustomerNameTextBox = new ComboBox();
            SuspendLayout();
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Location = new Point(23, 15);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(94, 15);
            CustomerNameLabel.TabIndex = 0;
            CustomerNameLabel.Text = "Customer Name";
            // 
            // AppointmentTypeLabel
            // 
            AppointmentTypeLabel.AutoSize = true;
            AppointmentTypeLabel.Location = new Point(12, 44);
            AppointmentTypeLabel.Name = "AppointmentTypeLabel";
            AppointmentTypeLabel.Size = new Size(105, 15);
            AppointmentTypeLabel.TabIndex = 1;
            AppointmentTypeLabel.Text = "Appointment Type";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(86, 73);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(31, 15);
            DateLabel.TabIndex = 3;
            DateLabel.Text = "Date";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(327, 128);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 8;
            BackButton.Text = "Cancel";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(246, 128);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(123, 70);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(279, 23);
            dateTimePicker.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 125);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 23;
            label1.Text = "(Between 9AM-5PM EST)";
            // 
            // AppointmentTypeTextBox
            // 
            AppointmentTypeTextBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AppointmentTypeTextBox.FormattingEnabled = true;
            AppointmentTypeTextBox.Items.AddRange(new object[] { "Scrum", "Meeting", "Presentation", "Lunch", "Tea Time", "Magic The Gathering Game", "Yu Gi Oh Game" });
            AppointmentTypeTextBox.Location = new Point(123, 41);
            AppointmentTypeTextBox.Name = "AppointmentTypeTextBox";
            AppointmentTypeTextBox.Size = new Size(279, 23);
            AppointmentTypeTextBox.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 102);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 31;
            label2.Text = "End Time";
            // 
            // EndTimeComboBox
            // 
            EndTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EndTimeComboBox.FormattingEnabled = true;
            EndTimeComboBox.Location = new Point(302, 99);
            EndTimeComboBox.Name = "EndTimeComboBox";
            EndTimeComboBox.Size = new Size(100, 23);
            EndTimeComboBox.TabIndex = 30;
            // 
            // StartTimeComboBox
            // 
            StartTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StartTimeComboBox.FormattingEnabled = true;
            StartTimeComboBox.Location = new Point(123, 99);
            StartTimeComboBox.Name = "StartTimeComboBox";
            StartTimeComboBox.Size = new Size(100, 23);
            StartTimeComboBox.TabIndex = 29;
            // 
            // StartTimeLabel
            // 
            StartTimeLabel.AutoSize = true;
            StartTimeLabel.Location = new Point(57, 102);
            StartTimeLabel.Name = "StartTimeLabel";
            StartTimeLabel.Size = new Size(60, 15);
            StartTimeLabel.TabIndex = 28;
            StartTimeLabel.Text = "Start Time";
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerNameTextBox.FormattingEnabled = true;
            CustomerNameTextBox.Location = new Point(123, 12);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(279, 23);
            CustomerNameTextBox.TabIndex = 32;
            // 
            // AddAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 169);
            Controls.Add(CustomerNameTextBox);
            Controls.Add(label2);
            Controls.Add(EndTimeComboBox);
            Controls.Add(StartTimeComboBox);
            Controls.Add(StartTimeLabel);
            Controls.Add(AppointmentTypeTextBox);
            Controls.Add(label1);
            Controls.Add(dateTimePicker);
            Controls.Add(SaveButton);
            Controls.Add(BackButton);
            Controls.Add(DateLabel);
            Controls.Add(AppointmentTypeLabel);
            Controls.Add(CustomerNameLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(435, 208);
            MinimumSize = new Size(435, 208);
            Name = "AddAppointmentForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Appointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CustomerNameLabel;
        private Label AppointmentTypeLabel;
        private Label DateLabel;
        private Button BackButton;
        private Button SaveButton;
        public DateTimePicker dateTimePicker;
        private Label label1;
        private ComboBox AppointmentTypeTextBox;
        private Label label2;
        private ComboBox EndTimeComboBox;
        private ComboBox StartTimeComboBox;
        private Label StartTimeLabel;
        private ComboBox CustomerNameTextBox;
    }
}