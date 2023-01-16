using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopService;
using ItemExplorer;

namespace Online_Shop
{
    /// <summary>
    /// This is indirect class that makes passing object of type Product as IItem possible.
    /// </summary>
    public class ProductItem : Product, IItem
    {
        /// <summary>
        /// Product Id
        /// </summary>
        public int Id { get => base.ProductId; set => base.ProductId = value; }
    }
}
