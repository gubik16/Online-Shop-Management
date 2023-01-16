namespace Online_Shop
{
    partial class OrderManagementForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.backButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backButton.Location = new System.Drawing.Point(0, 427);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(1052, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            // 
            // orderListBox
            // 
            this.orderListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.orderListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.ItemHeight = 20;
            this.orderListBox.Location = new System.Drawing.Point(0, 0);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(1052, 427);
            this.orderListBox.TabIndex = 2;
            this.orderListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.orderListBox_MouseDoubleClick);
            // 
            // OrderManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 450);
            this.Controls.Add(this.orderListBox);
            this.Controls.Add(this.backButton);
            this.Name = "OrderManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderManagementForm";
            this.Load += new System.EventHandler(this.OrderManagementForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListBox orderListBox;
    }
}