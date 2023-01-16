using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopService;

namespace Online_Shop
{
    /// <summary>
    /// Lists all orders and allows editing
    /// </summary>
    public partial class OrderManagementForm : Form
    {
        //Orders
        private List<Order> orders;

        //Order manager
        private OrderManager orderManager = new OrderManager();
        
        public OrderManagementForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Refreshes orders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderManagementForm_Load(object sender, EventArgs e)
        {
            RefreshOrders();
        }

        /// <summary>
        /// Closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Opens order editor with selected order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Get selected order
            Order order;
            order = orderListBox.SelectedItem as Order;

            //Create and open editor
            OrderEditorForm editor = new OrderEditorForm(order);
            editor.ShowDialog();

            //Refresh if order has been changed
            if (editor.Changed)
                RefreshOrders();
        }

        /// <summary>
        /// Updates order list in list box
        /// </summary>
        private void RefreshOrders()
        {
            orders = orderManager.GetAllOrders();
            orderListBox.DataSource = orders;
            orderListBox.DisplayMember = "OrderInfo";
        }

        /// <summary>
        /// Changes button color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            backButton.BackColor = ButtonColor.buttonEnter;
        }

        /// <summary>
        /// Changes button color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.BackColor = ButtonColor.buttonLeave;
        }
    }
}
