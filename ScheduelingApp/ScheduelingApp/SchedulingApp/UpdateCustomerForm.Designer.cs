namespace SchedulingApp
{
    partial class UpdateCustomerForm
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
            BackButton = new Button();
            SaveButton = new Button();
            PhoneNumberTextBox = new TextBox();
            AddressTextBox = new TextBox();
            CustomerNameTextBox = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // CancelButton
            // 
            BackButton.Location = new Point(331, 99);
            BackButton.Name = "CancelButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 23;
            BackButton.Text = "Cancel";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(250, 99);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 22;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(123, 70);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(283, 23);
            PhoneNumberTextBox.TabIndex = 20;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(123, 41);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(283, 23);
            AddressTextBox.TabIndex = 18;
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Location = new Point(123, 12);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(283, 23);
            CustomerNameTextBox.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 73);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 15;
            label4.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 44);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 13;
            label2.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 15);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 12;
            label1.Text = "Customer Name";
            // 
            // UpdateCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 131);
            Controls.Add(BackButton);
            Controls.Add(SaveButton);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(AddressTextBox);
            Controls.Add(CustomerNameTextBox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(435, 170);
            MinimumSize = new Size(435, 170);
            Name = "UpdateCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Button SaveButton;
        private TextBox PhoneNumberTextBox;
        private TextBox AddressTextBox;
        private TextBox CustomerNameTextBox;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}