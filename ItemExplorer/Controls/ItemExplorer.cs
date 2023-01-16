using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemExplorer
{
    public partial class ItemExplorer : UserControl
    {
        //Button color
        public Color buttonEneterColor;
        public Color buttonLeaveColor;
        
        //Interfaces declaration
        private IDatabaseService databaseService;
        private IItemCreator creator;
        private IItemEditor editor;

        /// <summary>
        /// Parameterless constructor
        /// </summary>
        public ItemExplorer()
        {
            InitializeComponent();
            buttonEneterColor = Color.FromArgb(240, 240, 240);
            buttonLeaveColor = Color.FromArgb(240, 240, 240);
        }

        /// <summary>
        /// Dependency injection constructor
        /// </summary>
        /// <param name="databaseService"></param>
        /// <param name="creator"></param>
        /// <param name="editor"></param>
        public ItemExplorer(IDatabaseService databaseService, IItemCreator creator, IItemEditor editor)
        {
            InitializeComponent();
            this.databaseService = databaseService;
            this.editor = editor;
            this.creator = creator;
        }

        /// <summary>
        /// Set database service
        /// </summary>
        /// <param name="databaseService"></param>
        public void setDatabaseService(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }

        /// <summary>
        /// Sets creator
        /// </summary>
        /// <param name="creator"></param>
        public void setCreator(IItemCreator creator)
        {
            this.creator = creator;
        }

        /// <summary>
        /// Sets editor
        /// </summary>
        /// <param name="editor"></param>
        public void setEditor(IItemEditor editor)
        {
            this.editor = editor;
        }

        /// <summary>
        /// Shows items in explorer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductExplorer_Load(object sender, EventArgs e)
        {
            //Setting button colors
            addButton.BackColor = buttonLeaveColor;
            refreshButton.BackColor = buttonLeaveColor;
            //Loading items
            ShowItems();
        }

        /// <summary>
        /// Refreshes items shown in explorer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshItems();
        }

        /// <summary>
        /// Uses creator to create and add new item to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            //Creating item with CreateItem method of creator
            IItem item = creator.CreateItem();

            //Checks for nulls. If item was successfully created, it is added to database and explorer is refreshed
            if (item == null && creator.ItemCreated == true)
                MessageBox.Show("Item is null!");
            else if (creator.ItemCreated && item != null)
            {
                databaseService.AddItem(item);
                RefreshItems();
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        /// <summary>
        /// Refreshes shown items on ItemChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Item_ItemChanged(object sender, EventArgs e)
        {
            RefreshItems();
        }

        /// <summary>
        /// Gets list of items from database, creates Item control for each of them and assings method to ItemChanged event
        /// </summary>
        public void ShowItems()
        {
            //Get list of items
            var items = databaseService.GetAllItems();

            //Create Item controls for items
            foreach(IItem i in items)
            {
                Item item = new Item(i, databaseService, editor);
                Panel.Controls.Add(item);
                item.ItemChanged += Item_ItemChanged;
            }
        }

        /// <summary>
        /// Clears Item controls and creates new ones
        /// </summary>
        public void RefreshItems()
        {
            Panel.Controls.Clear();
            ShowItems();
        }

        /// <summary>
        /// Changes button color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_MouseEnter(object sender, EventArgs e)
        {
            addButton.BackColor = buttonEneterColor;
        }

        /// <summary>
        /// Changes button color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_MouseLeave(object sender, EventArgs e)
        {
            addButton.BackColor = buttonLeaveColor;
        }

        /// <summary>
        /// Changes button color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshButton_MouseEnter(object sender, EventArgs e)
        {
            refreshButton.BackColor = buttonEneterColor;
        }

        /// <summary>
        /// Changes button color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshButton_MouseLeave(object sender, EventArgs e)
        {
            refreshButton.BackColor = buttonLeaveColor;
        }
    }
}
