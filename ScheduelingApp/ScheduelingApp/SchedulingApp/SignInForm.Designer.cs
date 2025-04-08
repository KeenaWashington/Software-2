namespace SchedulingApp
{
    partial class SignInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginInfoPanel = new Panel();
            PasswordTextBox = new TextBox();
            UsernameTextBox = new TextBox();
            PasswordLabel = new Label();
            UsernameLabel = new Label();
            LoginButton = new Button();
            LoginInfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginInfoPanel
            // 
            LoginInfoPanel.Anchor = AnchorStyles.None;
            LoginInfoPanel.BorderStyle = BorderStyle.Fixed3D;
            LoginInfoPanel.Controls.Add(PasswordTextBox);
            LoginInfoPanel.Controls.Add(UsernameTextBox);
            LoginInfoPanel.Controls.Add(PasswordLabel);
            LoginInfoPanel.Controls.Add(UsernameLabel);
            LoginInfoPanel.Location = new Point(11, 6);
            LoginInfoPanel.Margin = new Padding(3, 2, 3, 2);
            LoginInfoPanel.Name = "LoginInfoPanel";
            LoginInfoPanel.Size = new Size(344, 93);
            LoginInfoPanel.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.Location = new Point(95, 50);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(237, 23);
            PasswordTextBox.TabIndex = 3;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UsernameTextBox.Location = new Point(95, 18);
            UsernameTextBox.Margin = new Padding(3, 2, 3, 2);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(237, 23);
            UsernameTextBox.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(6, 53);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(3, 21);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(60, 15);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username";
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.None;
            LoginButton.BackColor = SystemColors.Control;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.Location = new Point(11, 107);
            LoginButton.Margin = new Padding(3, 2, 3, 2);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(344, 28);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // SignInForm
            // 
            AcceptButton = LoginButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(364, 146);
            Controls.Add(LoginButton);
            Controls.Add(LoginInfoPanel);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(380, 185);
            MinimizeBox = false;
            MinimumSize = new Size(380, 185);
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            LoginInfoPanel.ResumeLayout(false);
            LoginInfoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginInfoPanel;
        private Button LoginButton;
        private Label PasswordLabel;
        private Label UsernameLabel;
        private TextBox PasswordTextBox;
        private TextBox UsernameTextBox;
    }
}
