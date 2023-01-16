using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopService;

namespace Online_Shop
{
    /// <summary>
    /// Form used to edit order
    /// </summary>
    public partial class OrderEditorForm : Form
    {
        //Order to be edited
        private Order order;

        //Related entities
        private Customer customer;
        private List<OrderItem> products;

        private bool editMode = false; // Indicates whether edit mode is on

        private bool changed = false; // Indicates if the order has been changed
        public bool Changed { get { return changed; } }

        //Order manager
        private OrderManager orderManager = new OrderManager();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order">Order to be edited</param>
        public OrderEditorForm(Order order)
        {
            InitializeComponent();

            //Setting order and related entities
            this.order = order;
            customer = order.Customer;
            products = order.OrderItems.ToList();

            //Getting array of all order statuses and adding them to ComboBox
            var statusArr = Enum.GetValues(typeof(OrderStatus));
            foreach(var s in statusArr)
            {
                statusComboBox.Items.Add(s);
            }
        }

        /// <summary>
        /// Loads information about order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderEditorForm_Load(object sender, EventArgs e)
        {
            LoadOrderInfo();
        }

        /// <summary>
        /// Turns on edit mode. If edit mode is turned on then edit the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                //Editing customer info
                customer.FirstName = firstNameTextBox.Text;
                customer.LastName = lastNameTextBox.Text;

                //Editing date of order
                try
                {
                    order.Date = Convert.ToDateTime(dateTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Wrong date format. Date not changed.");
                }

                //Editing order status
                order.Status = (OrderStatus)statusComboBox.SelectedItem;

                //Editing address info
                order.Address.Country = countryTextBox.Text;
                order.Address.City = cityTextBox.Text;
                order.Address.ZipCode = zipCodeTextBox.Text;
                order.Address.Street = streetTextBox.Text;
                order.Address.HouseNumber = houseNumberTextBox.Text;

                //Editing order products
                order.OrderItems = products;

                //Updating order with OrderManager
                orderManager.UpdateOrder(order);

                changed = true; // Order has been changed
            }
            
            //Changing mode to edit mode
            ChangeMode();
        }
        
        /// <summary>
        /// If edit mode is on loads back original order info and changes mode. If edit mode is off closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            if(editMode)
            {
                ChangeMode();
                LoadOrderInfo();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        /// <summary>
        /// Loads order info into text boxes
        /// </summary>
        private void LoadOrderInfo()
        {
            //Customer
            firstNameTextBox.Text = customer.FirstName;
            lastNameTextBox.Text = customer.LastName;

            //Address
            countryTextBox.Text = order.Address.Country;
            cityTextBox.Text = order.Address.City;
            zipCodeTextBox.Text = order.Address.ZipCode;
            streetTextBox.Text = order.Address.Street;
            houseNumberTextBox.Text = order.Address.HouseNumber;

            //Order
            idTextBox.Text = order.OrderId.ToString();
            statusComboBox.SelectedItem = order.Status;
            dateTextBox.Text = order.Date.ToString();

            //Products
            products = order.OrderItems.ToList();

            LoadProductList();
        }
        
        /// <summary>
        /// Loads product list into text box
        /// </summary>
        private void LoadProductList()
        {
            string productsListed = "";

            foreach (var p in products)
            {
                productsListed += p.Product.Name + " x " + p.Quantity + " " + (p.Product.Price * p.Quantity).ToString("c", CultureInfo.CreateSpecificCulture("en-US"));
                productsListed += Environment.NewLine;
            }

            productsListed += "Total cost: " + GetCurrentPrice().ToString("c", CultureInfo.CreateSpecificCulture("en-US"));
            productsTextBox.Text = productsListed;
        }

        /// <summary>
        /// Turns edit mode on and off.
        /// With edit mode off text boxes are ReadOnly.
        /// With edit mode on text in text boxes can be edited and editButton text is set to "Save" and backButton text to "Cancel"
        /// </summary>
        private void ChangeMode()
        {
            //Changing editMode
            editMode = !editMode;

            //Changing ReadOnly property of text boxes
            firstNameTextBox.ReadOnly = !editMode;
            lastNameTextBox.ReadOnly = !editMode;
            countryTextBox.ReadOnly = !editMode;
            cityTextBox.ReadOnly = !editMode;
            zipCodeTextBox.ReadOnly = !editMode;
            streetTextBox.ReadOnly = !editMode;
            houseNumberTextBox.ReadOnly = !editMode;
            dateTextBox.ReadOnly = !editMode;
            statusComboBox.Enabled = editMode;

            //Change button texts
            if (editMode)
            {
                editButton.Text = "Save";
                backButton.Text = "Cancel";
            }
            else if (!editMode)
            {
                editButton.Text = "Edit";
                backButton.Text = "Back";
            }
        }

        /// <summary>
        /// Opens products editor if double clicked on text box displaying products
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productsTextBox_DoubleClick(object sender, EventArgs e)
        {
            //Can't edit products if edit mode is off
            if (!editMode)
                return;
            
            var productsEditor = new OrderItemsEditor(products);

            if (productsEditor.ShowDialog() == DialogResult.OK)
            {
                LoadProductList(); //Refresh products after edition
            }
        }

        /// <summary>
        /// Sets order status to Canceled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            //Confirmation form
            var confirmation = new ConfirmationForm("Cancel this order?");

            //If user pressed "Yes" change order status to Canceled
            if (confirmation.ShowDialog() == DialogResult.OK)
            {
                orderManager.ChangeOrderStatus(order.OrderId, OrderStatus.Canceled);
                changed = true;
            }
        }

        /// <summary>
        /// Deletes order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Confirmation form
            var confirmation = new ConfirmationForm("Delete this order?");

            //If user pressed "Yes" delete order
            if (confirmation.ShowDialog() == DialogResult.OK)
            {
                orderManager.DeleteOrder(order.OrderId);
                changed = true;
                this.Close();
            }
        }

        /// <summary>
        /// Calculates price of the whole order
        /// </summary>
        /// <returns>Total order price</returns>
        private float GetCurrentPrice()
        {
            float price = 0;
            foreach(var p in products)
            {
                price += p.Product.Price * p.Quantity;
            }
            return price;
        }

        /// <summary>
        /// Changes button color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_MouseEnter(object sender, EventArgs e)
        {
            editButton.BackColor = ButtonColor.buttonEnter;
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
        private void cancelOrderButton_MouseEnter(object sender, EventArgs e)
        {
            cancelOrderButton.BackColor = ButtonColor.buttonEnter;
        }

        /// <summary>
        /// Changes button color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_MouseEnter(object sender, EventArgs e)
        {
            deleteButton.BackColor = ButtonColor.buttonEnter;
        }

        /// <summary>
        /// Changes button color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_MouseLeave(object sender, EventArgs e)
        {
            editButton.BackColor = ButtonColor.buttonLeave;
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

        /// <summary>
        /// Changes button color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelOrderButton_MouseLeave(object sender, EventArgs e)
        {
            cancelOrderButton.BackColor = ButtonColor.buttonLeave;
        }

        /// <summary>
        /// Changes button color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_MouseLeave(object sender, EventArgs e)
        {
            deleteButton.BackColor = ButtonColor.buttonLeave;
        }
    }
}
