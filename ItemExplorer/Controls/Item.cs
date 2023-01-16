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
    /// <summary>
    /// Stores an item and displays it's image and name.
    /// Allows edition and deletion of the item and saves it to database.
    /// </summary>
    public partial class Item : UserControl
    {
        //Interfaces declaration
        public IItem item;
        private IDatabaseService databaseService;
        private IItemEditor editor;

        //Events declaration
        public event EventHandler ItemChanged;

        /// <summary>
        /// Constructor that uses dependency injection
        /// </summary>
        /// <param name="item">Item stored by the control</param>
        /// <param name="databaseService">Database provider</param>
        /// <param name="editor">Form used to edit stored item</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Item(IItem item, IDatabaseService databaseService, IItemEditor editor)
        {
            //Argument check
            if (item == null || databaseService == null || editor == null)
                throw new ArgumentNullException("One of the arguments is null!");
            
            //Initialize control
            InitializeComponent();

            //Assignment of objects passed by dependency injection
            this.item = item;
            this.databaseService = databaseService;
            this.editor = editor;

            //Context menu creation
            var contextMenu = new ContextMenuStrip();
            this.ContextMenuStrip = contextMenu;

            //Adding menu item and event for item editing
            var menuItemEdit = new ToolStripMenuItem();
            menuItemEdit.Text = "Edit";
            contextMenu.Items.Add(menuItemEdit);

            menuItemEdit.Click += MenuItemEdit_Click;


            //Adding menu item and event for deleting the item
            var menuItemDelete = new ToolStripMenuItem();
            menuItemDelete.Text = "Delete";
            contextMenu.Items.Add(menuItemDelete);

            menuItemDelete.Click += menuItemDelete_Click;
        }

        /// <summary>
        /// Sets the picturebox and label to show item info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Item_Load(object sender, EventArgs e)
        {
            NameLabel.Text = item.Name;
            pictureBox1.Image = ImgConverter.toImage(item.Img);
        }

        /// <summary>
        /// Calls ItemChanged event
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnItemChanged(EventArgs e)
        {
            ItemChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Edits item using editor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemEdit_Click(object sender, EventArgs e)
        {
            //Creating new item using EditItem method of editor
            IItem editedItem = editor.EditItem(item);

            //Editin item in database if it isn't null and calls ItemChanged event
            if (editedItem is null && editor.ItemModified)
                MessageBox.Show("Edited item is null!");
            else if(editor.ItemModified)
            {
                databaseService.Edit(editedItem);
                OnItemChanged(EventArgs.Empty);
            }
        }

        /// <summary>
        /// Deletes item from database and refreshes items shown in explorer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            databaseService.Remove(item.Id);

            ItemExplorer ie = (ItemExplorer)this.Parent.Parent;
            ie.RefreshItems();
        }
    }
}
