using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Shop
{
    /// <summary>
    /// Uses ItemExplorer to display all products
    /// </summary>
    public partial class ExplorerForm : Form
    {
        public ExplorerForm()
        {
            InitializeComponent();

            //Setting db service, creator and editor
            this.productExplorer1.setDatabaseService(new ProductDatabaseService());
            this.productExplorer1.setCreator(new ProductCreator());
            this.productExplorer1.setEditor(new ProductCreator());

            //Setting colors for ItemExplorer
            this.productExplorer1.buttonEneterColor = ButtonColor.buttonEnter;
            this.productExplorer1.buttonLeaveColor = ButtonColor.buttonLeave;
        }

        /// <summary>
        /// Closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Changes button color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = ButtonColor.buttonEnter;
        }

        /// <summary>
        /// Changes button color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = ButtonColor.buttonLeave;
        }
    }
}
