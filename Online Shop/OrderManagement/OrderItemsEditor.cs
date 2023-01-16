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
    /// Edit order products
    /// </summary>
    public partial class OrderItemsEditor : Form
    {
        //Collection of products
        ICollection<OrderItem> products;

        /// <summary>
        /// Initializes component and sets products
        /// </summary>
        /// <param name="products"></param>
        public OrderItemsEditor(ICollection<OrderItem> products)
        {
            InitializeComponent();
            this.products = products;
        }

        /// <summary>
        /// Sets productsGridView columns and it's context menu. Loads products to listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderItemsEditor_Load(object sender, EventArgs e)
        {
            //Turning of automatic column generation
            productsGridView.AutoGenerateColumns = false;
            //Setting products as data source
            productsGridView.DataSource = products;

            //Column setup
            SetGridColumn("ProductId", "Id");
            productsGridView.Columns[0].Width = 40;
            SetGridColumn("ProductName", "Name");
            SetGridColumn("Quantity", "Quantity");
            productsGridView.Columns[2].ReadOnly = false;

            //Context menu setup
            var contextMenu = new ContextMenuStrip();
            productsGridView.ContextMenuStrip = contextMenu;
            //Context menu items
            var menuItem = new ToolStripMenuItem();
            menuItem.Text = "Remove";
            contextMenu.Items.Add(menuItem);
            menuItem.Click += menuItemRemove_Click;

            //Load products
            LoadAllProducts();
        }

        /// <summary>
        /// Removes selected product from productGridView.
        /// At least one product must be left.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemRemove_Click(object sender, EventArgs e)
        {
            //Checking if user wants to remove all products
            if(products.Count == productsGridView.SelectedRows.Count)
            {
                MessageBox.Show("Order must have at least one product!");
                return;
            }
            
            //Remove selected products
            foreach(DataGridViewRow row in productsGridView.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                var product = products.Where(p => p.ProductId == id).First();
                products.Remove(product);
            }
            //Refresh grid
            RefreshGrid();
        }

        /// <summary>
        /// Creates new grid column
        /// </summary>
        /// <param name="property">Property that will be represented by column</param>
        /// <param name="name">Column name</param>
        private void SetGridColumn(string property, string name)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();

            column.DataPropertyName = property;
            column.HeaderText = name;
            column.ReadOnly = true;

            productsGridView.Columns.Add(column);
        }

        /// <summary>
        /// Loads list of all avaible products to list box
        /// </summary>
        private void LoadAllProducts()
        {
            var productList = Repository<Product>.GetAll();

            productsListBox.DataSource = productList;
            productsListBox.DisplayMember = "ProductInfo";
        }

        /// <summary>
        /// Adds selected product to productsGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (var ctx = new ShopContext())
            {
                //Getting id of selected products
                var productId = (productsListBox.SelectedItem as Product).ProductId;

                //Return if product is already added to grid view
                if (products.Any(p => p.ProductId == productId))
                    return;

                //Get product from database
                var product = ctx.Products.Find(productId);

                //Create new OrderItem containig selected product
                var orderItem = new OrderItem()
                {
                    Quantity = 1,
                    ProductId = productId,
                    Product = product,
                    Order = products.First().Order,
                    OrderId = products.First().OrderId,
                };

                //Add order item to products
                products.Add(orderItem);
                //Refresh grid
                RefreshGrid();
            }
        }

        /// <summary>
        /// Closes form without saving new products
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Resets grid's data source and refresh
        /// </summary>
        private void RefreshGrid()
        {
            productsGridView.DataSource = null;
            productsGridView.DataSource = products;
            productsGridView.Refresh();
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
