namespace Online_Shop
{
    partial class OrderItemsEditor
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
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productsListBox
            // 
            this.productsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.productsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.ItemHeight = 16;
            this.productsListBox.Location = new System.Drawing.Point(12, 12);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(243, 388);
            this.productsListBox.TabIndex = 0;
            this.productsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.productsListBox_MouseDoubleClick);
            // 
            // productsGridView
            // 
            this.productsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Location = new System.Drawing.Point(299, 12);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.Size = new System.Drawing.Size(243, 388);
            this.productsGridView.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.backButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.Location = new System.Drawing.Point(0, 423);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(554, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            // 
            // OrderItemsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(554, 446);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.productsGridView);
            this.Controls.Add(this.productsListBox);
            this.Name = "OrderItemsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderItemsEditor";
            this.Load += new System.EventHandler(this.OrderItemsEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox productsListBox;
        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.Button backButton;
    }
}