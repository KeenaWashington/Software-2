namespace SchedulingApp
{
    partial class HomeForm
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
            CustomerRecordsButton = new Button();
            AppointmentsButton = new Button();
            ReportsButton = new Button();
            SuspendLayout();
            // 
            // CustomerRecordsButton
            // 
            CustomerRecordsButton.Location = new Point(12, 12);
            CustomerRecordsButton.Name = "CustomerRecordsButton";
            CustomerRecordsButton.Size = new Size(112, 23);
            CustomerRecordsButton.TabIndex = 0;
            CustomerRecordsButton.Text = "Customer Records";
            CustomerRecordsButton.UseVisualStyleBackColor = true;
            CustomerRecordsButton.Click += CustomerRecordsButton_Click;
            // 
            // AppointmentsButton
            // 
            AppointmentsButton.Location = new Point(130, 12);
            AppointmentsButton.Name = "AppointmentsButton";
            AppointmentsButton.Size = new Size(92, 23);
            AppointmentsButton.TabIndex = 1;
            AppointmentsButton.Text = "Appointments";
            AppointmentsButton.UseVisualStyleBackColor = true;
            AppointmentsButton.Click += AppointmentsButton_Click;
            // 
            // ReportsButton
            // 
            ReportsButton.Location = new Point(228, 12);
            ReportsButton.Name = "ReportsButton";
            ReportsButton.Size = new Size(75, 23);
            ReportsButton.TabIndex = 2;
            ReportsButton.Text = "Reports";
            ReportsButton.UseVisualStyleBackColor = true;
            ReportsButton.Click += ReportsButton_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 46);
            Controls.Add(ReportsButton);
            Controls.Add(AppointmentsButton);
            Controls.Add(CustomerRecordsButton);
            MaximumSize = new Size(330, 85);
            MinimumSize = new Size(330, 85);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private Button CustomerRecordsButton;
        private Button AppointmentsButton;
        private Button ReportsButton;
    }
}