using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopService;
using ItemExplorer;

namespace Online_Shop
{
    /// <summary>
    /// Online shop main menu
    /// </summary>
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form setup. Provides commented code that adds new order to database for debugging purposes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_Load(object sender, EventArgs e)
        {
            //Buttons setup
            button1.Location = new Point((this.Size.Width / 2 - button1.Size.Width / 2), button1.Location.Y);
            button2.Location = new Point((this.Size.Width / 2 - button1.Size.Width / 2), button2.Location.Y);
            button3.Location = new Point((this.Size.Width / 2 - button1.Size.Width / 2), button3.Location.Y);

            //Use this code to add new order when starting application
            /*var address = new Address()
            {
                City = "Szczecin",
                Country = "Poland",
                Street = "ale urwal",
                ZipCode = "69-666",
                HouseNumber = "15b"
            };

            var customer = new Customer()
            {
                FirstName = "Jan",
                LastName = "Kowal",
            };

            var products = new List<OrderItem>();
            var orderitem = new OrderItem()
            {
                ProductId = 3,
                Quantity = 1
            };
            products.Add(orderitem);

            OrderManager om = new OrderManager();
            om.CreateOrder(customer, address, products);*/
        }

        /// <summary>
        /// Opens order manager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            OrderManagementForm orderManager = new OrderManagementForm();
            this.Hide();
            if (orderManager.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        /// <summary>
        /// Opens product explorer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ExplorerForm explorer = new ExplorerForm();
            this.Hide();
            if (explorer.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        /// <summary>
        /// Closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
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
        /// <summary>
        /// Changes button color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = ButtonColor.buttonEnter;
        }
        /// <summary>
        /// Changes button color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = ButtonColor.buttonLeave;
        }
        /// <summary>
        /// Changes button color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = ButtonColor.buttonEnter;
        }
        /// <summary>
        /// Changes button color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = ButtonColor.buttonLeave;
        }

    }
}
