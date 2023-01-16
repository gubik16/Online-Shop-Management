namespace Online_Shop
{
    partial class OrderEditorForm
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
            this.addressLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.customerInfoLabel = new System.Windows.Forms.Label();
            this.customerPanel = new System.Windows.Forms.Panel();
            this.houseNumberTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.orderInfoLabel = new System.Windows.Forms.Label();
            this.orderPanel = new System.Windows.Forms.Panel();
            this.productsTextBox = new System.Windows.Forms.TextBox();
            this.productsLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.cancelOrderButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.customerPanel.SuspendLayout();
            this.orderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addressLabel.Location = new System.Drawing.Point(0, 88);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(69, 18);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameLabel.Location = new System.Drawing.Point(0, 44);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(89, 18);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameLabel.Location = new System.Drawing.Point(0, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(91, 18);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.lastNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameTextBox.Location = new System.Drawing.Point(0, 62);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(216, 26);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.firstNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameTextBox.Location = new System.Drawing.Point(0, 18);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(216, 26);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // customerInfoLabel
            // 
            this.customerInfoLabel.AutoSize = true;
            this.customerInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customerInfoLabel.Location = new System.Drawing.Point(12, 9);
            this.customerInfoLabel.Name = "customerInfoLabel";
            this.customerInfoLabel.Size = new System.Drawing.Size(139, 24);
            this.customerInfoLabel.TabIndex = 6;
            this.customerInfoLabel.Text = "Customer Info";
            // 
            // customerPanel
            // 
            this.customerPanel.Controls.Add(this.houseNumberTextBox);
            this.customerPanel.Controls.Add(this.streetTextBox);
            this.customerPanel.Controls.Add(this.zipCodeTextBox);
            this.customerPanel.Controls.Add(this.cityTextBox);
            this.customerPanel.Controls.Add(this.countryTextBox);
            this.customerPanel.Controls.Add(this.addressLabel);
            this.customerPanel.Controls.Add(this.lastNameTextBox);
            this.customerPanel.Controls.Add(this.lastNameLabel);
            this.customerPanel.Controls.Add(this.firstNameTextBox);
            this.customerPanel.Controls.Add(this.firstNameLabel);
            this.customerPanel.Location = new System.Drawing.Point(16, 36);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(216, 237);
            this.customerPanel.TabIndex = 7;
            // 
            // houseNumberTextBox
            // 
            this.houseNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.houseNumberTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.houseNumberTextBox.Location = new System.Drawing.Point(0, 210);
            this.houseNumberTextBox.Name = "houseNumberTextBox";
            this.houseNumberTextBox.ReadOnly = true;
            this.houseNumberTextBox.Size = new System.Drawing.Size(216, 26);
            this.houseNumberTextBox.TabIndex = 9;
            // 
            // streetTextBox
            // 
            this.streetTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.streetTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.streetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.streetTextBox.Location = new System.Drawing.Point(0, 184);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.ReadOnly = true;
            this.streetTextBox.Size = new System.Drawing.Size(216, 26);
            this.streetTextBox.TabIndex = 8;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.zipCodeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.zipCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zipCodeTextBox.Location = new System.Drawing.Point(0, 158);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.ReadOnly = true;
            this.zipCodeTextBox.Size = new System.Drawing.Size(216, 26);
            this.zipCodeTextBox.TabIndex = 7;
            // 
            // cityTextBox
            // 
            this.cityTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.cityTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cityTextBox.Location = new System.Drawing.Point(0, 132);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(216, 26);
            this.cityTextBox.TabIndex = 6;
            // 
            // countryTextBox
            // 
            this.countryTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.countryTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.countryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.countryTextBox.Location = new System.Drawing.Point(0, 106);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.ReadOnly = true;
            this.countryTextBox.Size = new System.Drawing.Size(216, 26);
            this.countryTextBox.TabIndex = 5;
            // 
            // orderInfoLabel
            // 
            this.orderInfoLabel.AutoSize = true;
            this.orderInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orderInfoLabel.Location = new System.Drawing.Point(296, 9);
            this.orderInfoLabel.Name = "orderInfoLabel";
            this.orderInfoLabel.Size = new System.Drawing.Size(104, 24);
            this.orderInfoLabel.TabIndex = 8;
            this.orderInfoLabel.Text = "Order Info";
            // 
            // orderPanel
            // 
            this.orderPanel.Controls.Add(this.productsTextBox);
            this.orderPanel.Controls.Add(this.productsLabel);
            this.orderPanel.Controls.Add(this.statusComboBox);
            this.orderPanel.Controls.Add(this.statusLabel);
            this.orderPanel.Controls.Add(this.dateTextBox);
            this.orderPanel.Controls.Add(this.dateLabel);
            this.orderPanel.Controls.Add(this.idTextBox);
            this.orderPanel.Controls.Add(this.idLabel);
            this.orderPanel.Location = new System.Drawing.Point(297, 36);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(269, 303);
            this.orderPanel.TabIndex = 9;
            // 
            // productsTextBox
            // 
            this.productsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.productsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.productsTextBox.Location = new System.Drawing.Point(0, 152);
            this.productsTextBox.Multiline = true;
            this.productsTextBox.Name = "productsTextBox";
            this.productsTextBox.ReadOnly = true;
            this.productsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.productsTextBox.Size = new System.Drawing.Size(269, 151);
            this.productsTextBox.TabIndex = 7;
            this.productsTextBox.DoubleClick += new System.EventHandler(this.productsTextBox_DoubleClick);
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.productsLabel.Location = new System.Drawing.Point(0, 134);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(76, 18);
            this.productsLabel.TabIndex = 6;
            this.productsLabel.Text = "Products";
            // 
            // statusComboBox
            // 
            this.statusComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.statusComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.Enabled = false;
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(0, 106);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(269, 28);
            this.statusComboBox.TabIndex = 12;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusLabel.Location = new System.Drawing.Point(0, 88);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(104, 18);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Order Status";
            // 
            // dateTextBox
            // 
            this.dateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.dateTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTextBox.Location = new System.Drawing.Point(0, 62);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(269, 26);
            this.dateTextBox.TabIndex = 3;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateLabel.Location = new System.Drawing.Point(0, 44);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(43, 18);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date";
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.idTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idTextBox.Location = new System.Drawing.Point(0, 18);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(269, 26);
            this.idTextBox.TabIndex = 1;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idLabel.Location = new System.Drawing.Point(0, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 18);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Id";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.Location = new System.Drawing.Point(12, 317);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editButton.Location = new System.Drawing.Point(12, 288);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            this.editButton.MouseEnter += new System.EventHandler(this.editButton_MouseEnter);
            this.editButton.MouseLeave += new System.EventHandler(this.editButton_MouseLeave);
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cancelOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelOrderButton.Location = new System.Drawing.Point(132, 288);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(100, 23);
            this.cancelOrderButton.TabIndex = 13;
            this.cancelOrderButton.Text = "Cancel Order";
            this.cancelOrderButton.UseVisualStyleBackColor = false;
            this.cancelOrderButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.cancelOrderButton.MouseEnter += new System.EventHandler(this.cancelOrderButton_MouseEnter);
            this.cancelOrderButton.MouseLeave += new System.EventHandler(this.cancelOrderButton_MouseLeave);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteButton.Location = new System.Drawing.Point(132, 316);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 23);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete Order";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.MouseEnter += new System.EventHandler(this.deleteButton_MouseEnter);
            this.deleteButton.MouseLeave += new System.EventHandler(this.deleteButton_MouseLeave);
            // 
            // OrderEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(578, 352);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelOrderButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.orderPanel);
            this.Controls.Add(this.orderInfoLabel);
            this.Controls.Add(this.customerPanel);
            this.Controls.Add(this.customerInfoLabel);
            this.Name = "OrderEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderManagementForm";
            this.Load += new System.EventHandler(this.OrderEditorForm_Load);
            this.customerPanel.ResumeLayout(false);
            this.customerPanel.PerformLayout();
            this.orderPanel.ResumeLayout(false);
            this.orderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label customerInfoLabel;
        private System.Windows.Forms.Panel customerPanel;
        private System.Windows.Forms.Label orderInfoLabel;
        private System.Windows.Forms.Panel orderPanel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox productsTextBox;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox houseNumberTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Button cancelOrderButton;
        private System.Windows.Forms.Button deleteButton;
    }
}