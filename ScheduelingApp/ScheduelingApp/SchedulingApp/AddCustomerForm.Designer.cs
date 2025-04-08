namespace SchedulingApp
{
    partial class AddCustomerForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            CustomerNameTextBox = new TextBox();
            AddressTextBox = new TextBox();
            PostalCodeTextBox = new TextBox();
            PhoneNumberTextBox = new TextBox();
            CityComboBox = new ComboBox();
            SaveButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 15);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 44);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 73);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Postal Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 102);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 131);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "City";
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Location = new Point(123, 12);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(283, 23);
            CustomerNameTextBox.TabIndex = 5;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(123, 41);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(283, 23);
            AddressTextBox.TabIndex = 6;
            // 
            // PostalCodeTextBox
            // 
            PostalCodeTextBox.Location = new Point(123, 70);
            PostalCodeTextBox.Name = "PostalCodeTextBox";
            PostalCodeTextBox.Size = new Size(283, 23);
            PostalCodeTextBox.TabIndex = 7;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(123, 99);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(283, 23);
            PhoneNumberTextBox.TabIndex = 8;
            // 
            // CityComboBox
            // 
            CityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CityComboBox.FormattingEnabled = true;
            CityComboBox.Items.AddRange(new object[] { "New York", "Los Angeles", "Toronto", "Vancouver", "Oslo" });
            CityComboBox.Location = new Point(123, 128);
            CityComboBox.Name = "CityComboBox";
            CityComboBox.Size = new Size(283, 23);
            CityComboBox.TabIndex = 9;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(250, 160);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(331, 160);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 11;
            BackButton.Text = "Cancel";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 193);
            ControlBox = false;
            Controls.Add(BackButton);
            Controls.Add(SaveButton);
            Controls.Add(CityComboBox);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(PostalCodeTextBox);
            Controls.Add(AddressTextBox);
            Controls.Add(CustomerNameTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(437, 232);
            MinimumSize = new Size(437, 232);
            Name = "AddCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox CustomerNameTextBox;
        private TextBox AddressTextBox;
        private TextBox PostalCodeTextBox;
        private TextBox PhoneNumberTextBox;
        private ComboBox CityComboBox;
        private Button SaveButton;
        private Button BackButton;
    }
}