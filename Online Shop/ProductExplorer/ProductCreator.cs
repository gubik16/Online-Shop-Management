using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemExplorer;
using ShopService;

namespace Online_Shop
{
    /// <summary>
    /// Creates or edits product
    /// </summary>
    public partial class ProductCreator : Form, IItemCreator, IItemEditor
    {
        //Products to be created
        private ProductItem product;

        //From IItemCreator
        public bool ItemCreated { get; set; }

        //From IItemEditor
        public bool ItemModified { get; set; }

        //Indicates if product is being edited or created
        private bool editMode = false;
        //Indicates if the image of edited item has been changed
        private bool imgChanged = false;
        public ProductCreator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets image from file dialog and saves it to picture box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(dlg.FileName);
                    imgChanged = true;
                }
                GC.Collect();
            }
        }

        /// <summary>
        /// Adds or edits product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void addButton_Click(object sender, EventArgs e)
        {
            //Checking if input valuse are correct
            Check:
            //Name and price empty
            if (String.IsNullOrEmpty(nameBox.Text) ||
               String.IsNullOrEmpty(priceBox.Text))
            {
                MessageBox.Show("Fill all required boxes");
                goto Check;
            }

            //Correct price
            float price;
            bool correctPrice = float.TryParse(priceBox.Text, out price);

            if (!correctPrice)
            {
                MessageBox.Show("Price is not a number");
                goto Check;
            }

            //Converting image
            byte[] image;

            if (imgChanged)
                image = ImgConverter.toByteArray(pictureBox1.Image);
            else if (editMode)
                image = product.Img;
            else
                image = ImgConverter.toByteArray(pictureBox1.Image);

            //Creating new ProductItem
            product = new ProductItem()
            {
                Name = nameBox.Text,
                Price = price,
                Description = descriptionBox.Text,
                Img = image
            };

            ItemCreated = true; //Item successfully created

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        
        /// <summary>
        /// Shows this form and return created/edited product when it's closed correctly
        /// </summary>
        /// <returns></returns>
        public IItem CreateItem()
        {
            if (this.ShowDialog() == DialogResult.OK)
                return product;
            else
                return null;
        }

        /// <summary>
        /// Sets text boxes and picture box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductCreator_Shown(object sender, EventArgs e)
        {
            //If edit mode is on sets field values to corresponding product values
            if (editMode)
            {
                //Edit mode setup
                ItemModified = false;
                addButton.Text = "Edit";
                imgChanged = false;

                //Picture and text boxes setup
                nameBox.Text = product.Name;
                priceBox.Text = product.Price.ToString("N");
                descriptionBox.Text = product.Description;
                pictureBox1.Image = ImgConverter.toImage(product.Img);
            }
            else
            {
                //Edit mode off setup
                ItemCreated = false;
                product = null;

                addButton.Text = "Add";

                //Picture and text boxes setup
                nameBox.Text = "";
                priceBox.Text = "";
                descriptionBox.Text = "Description";
                pictureBox1.Image = Properties.Resources.img;
            }
        }

        /// <summary>
        /// Edits product
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Edited product</returns>
        public IItem EditItem(IItem item)
        {
            editMode = true;
            product = item as ProductItem;

            var result = this.ShowDialog();
            editMode = false;

            //Return edited product
            if (result == DialogResult.OK)
            {
                product.ProductId = item.Id;
                ItemModified = true;
                return product;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Changes button color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_MouseEnter(object sender, EventArgs e)
        {
            addButton.BackColor = ButtonColor.buttonEnter;
        }

        /// <summary>
        /// Changes button color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_MouseLeave(object sender, EventArgs e)
        {
            addButton.BackColor = ButtonColor.buttonLeave;
        }
    }
}
