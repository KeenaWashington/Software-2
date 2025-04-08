namespace SchedulingApp
{
    partial class UpdateAppointmentForm
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
            StartTimeComboBox = new ComboBox();
            SaveButton = new Button();
            BackButton = new Button();
            DateLabel = new Label();
            StartTimeLabel = new Label();
            AppointmentTypeLabel = new Label();
            CustomerNameLabel = new Label();
            dateTimePicker = new DateTimePicker();
            label1 = new Label();
            AppointmentTypeTextBox = new ComboBox();
            EndTimeComboBox = new ComboBox();
            label2 = new Label();
            CustomerNameTextBox = new ComboBox();
            SuspendLayout();
            // 
            // StartTimeComboBox
            // 
            StartTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StartTimeComboBox.FormattingEnabled = true;
            StartTimeComboBox.Location = new Point(123, 99);
            StartTimeComboBox.Name = "StartTimeComboBox";
            StartTimeComboBox.Size = new Size(100, 23);
            StartTimeComboBox.TabIndex = 20;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(246, 128);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 19;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(327, 128);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 18;
            BackButton.Text = "Cancel";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(86, 73);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(31, 15);
            DateLabel.TabIndex = 14;
            DateLabel.Text = "Date";
            // 
            // StartTimeLabel
            // 
            StartTimeLabel.AutoSize = true;
            StartTimeLabel.Location = new Point(57, 102);
            StartTimeLabel.Name = "StartTimeLabel";
            StartTimeLabel.Size = new Size(60, 15);
            StartTimeLabel.TabIndex = 13;
            StartTimeLabel.Text = "Start Time";
            // 
            // AppointmentTypeLabel
            // 
            AppointmentTypeLabel.AutoSize = true;
            AppointmentTypeLabel.Location = new Point(12, 44);
            AppointmentTypeLabel.Name = "AppointmentTypeLabel";
            AppointmentTypeLabel.Size = new Size(105, 15);
            AppointmentTypeLabel.TabIndex = 12;
            AppointmentTypeLabel.Text = "Appointment Type";
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Location = new Point(23, 15);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(94, 15);
            CustomerNameLabel.TabIndex = 11;
            CustomerNameLabel.Text = "Customer Name";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(123, 70);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(279, 23);
            dateTimePicker.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 125);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 22;
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
            AppointmentTypeTextBox.TabIndex = 25;
            // 
            // EndTimeComboBox
            // 
            EndTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EndTimeComboBox.FormattingEnabled = true;
            EndTimeComboBox.Location = new Point(302, 99);
            EndTimeComboBox.Name = "EndTimeComboBox";
            EndTimeComboBox.Size = new Size(100, 23);
            EndTimeComboBox.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 102);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 27;
            label2.Text = "End Time";
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerNameTextBox.FormattingEnabled = true;
            CustomerNameTextBox.Location = new Point(123, 12);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(279, 23);
            CustomerNameTextBox.TabIndex = 33;
            // 
            // UpdateAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 169);
            Controls.Add(CustomerNameTextBox);
            Controls.Add(label2);
            Controls.Add(EndTimeComboBox);
            Controls.Add(AppointmentTypeTextBox);
            Controls.Add(label1);
            Controls.Add(dateTimePicker);
            Controls.Add(StartTimeComboBox);
            Controls.Add(SaveButton);
            Controls.Add(BackButton);
            Controls.Add(DateLabel);
            Controls.Add(StartTimeLabel);
            Controls.Add(AppointmentTypeLabel);
            Controls.Add(CustomerNameLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(435, 208);
            MinimumSize = new Size(435, 208);
            Name = "UpdateAppointmentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Appointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox StartTimeComboBox;
        private Button SaveButton;
        private Button BackButton;
        private Label DateLabel;
        private Label StartTimeLabel;
        private Label AppointmentTypeLabel;
        private Label CustomerNameLabel;
        public DateTimePicker dateTimePicker;
        private Label label1;
        private ComboBox AppointmentTypeTextBox;
        private ComboBox EndTimeComboBox;
        private Label label2;
        private ComboBox CustomerNameTextBox;
    }
}