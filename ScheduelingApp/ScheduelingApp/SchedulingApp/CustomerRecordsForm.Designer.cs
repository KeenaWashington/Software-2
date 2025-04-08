namespace SchedulingApp
{
    partial class CustomerRecordsForm
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
            CustomerTable = new DataGridView();
            CustomerNameColumn = new DataGridViewTextBoxColumn();
            AddressColumn = new DataGridViewTextBoxColumn();
            PhoneNumberColumn = new DataGridViewTextBoxColumn();
            CustomerIdColumn = new DataGridViewTextBoxColumn();
            AddButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            HomeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)CustomerTable).BeginInit();
            SuspendLayout();
            // 
            // CustomerTable
            // 
            CustomerTable.AllowUserToAddRows = false;
            CustomerTable.AllowUserToDeleteRows = false;
            CustomerTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomerTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerTable.Columns.AddRange(new DataGridViewColumn[] { CustomerNameColumn, AddressColumn, PhoneNumberColumn, CustomerIdColumn });
            CustomerTable.Location = new Point(108, 12);
            CustomerTable.Name = "CustomerTable";
            CustomerTable.ReadOnly = true;
            CustomerTable.RowHeadersVisible = false;
            CustomerTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            CustomerTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerTable.Size = new Size(434, 337);
            CustomerTable.TabIndex = 0;
            // 
            // CustomerNameColumn
            // 
            CustomerNameColumn.HeaderText = "Customer Name";
            CustomerNameColumn.Name = "CustomerNameColumn";
            CustomerNameColumn.ReadOnly = true;
            CustomerNameColumn.Resizable = DataGridViewTriState.False;
            CustomerNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // AddressColumn
            // 
            AddressColumn.HeaderText = "Address";
            AddressColumn.Name = "AddressColumn";
            AddressColumn.ReadOnly = true;
            AddressColumn.Resizable = DataGridViewTriState.False;
            AddressColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PhoneNumberColumn
            // 
            PhoneNumberColumn.HeaderText = "Phone Number";
            PhoneNumberColumn.Name = "PhoneNumberColumn";
            PhoneNumberColumn.ReadOnly = true;
            PhoneNumberColumn.Resizable = DataGridViewTriState.False;
            PhoneNumberColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // CustomerIdColumn
            // 
            CustomerIdColumn.HeaderText = "Customer Id";
            CustomerIdColumn.Name = "CustomerIdColumn";
            CustomerIdColumn.ReadOnly = true;
            CustomerIdColumn.Visible = false;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(12, 12);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(12, 41);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(75, 23);
            UpdateButton.TabIndex = 2;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(12, 70);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(12, 144);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(75, 23);
            HomeButton.TabIndex = 4;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // CustomerRecordsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 361);
            Controls.Add(HomeButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(CustomerTable);
            MaximumSize = new Size(570, 400);
            MinimumSize = new Size(570, 400);
            Name = "CustomerRecordsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Records";
            ((System.ComponentModel.ISupportInitialize)CustomerTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button HomeButton;
        private DataGridViewTextBoxColumn CustomerNameColumn;
        private DataGridViewTextBoxColumn AddressColumn;
        private DataGridViewTextBoxColumn PhoneNumberColumn;
        private DataGridViewTextBoxColumn CustomerIdColumn;
        public DataGridView CustomerTable;
    }
}