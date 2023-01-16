using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemExplorer;
using ShopService;

namespace Online_Shop
{
    /// <summary>
    /// Provides database operations based on IDatabaseService interface
    /// </summary>
    public class ProductDatabaseService : IDatabaseService
    {
        /// <summary>
        /// Removes product from database
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            Repository<Product>.Remove(id);
        }

        /// <summary>
        /// Gets all products
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IItem> GetAllItems()
        {
            var products = Repository<Product>.GetAll();
            foreach(var p in products)
            {
                yield return ProductItemConverter.Convert(p);
            }
        }

        /// <summary>
        /// Adds new product
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(IItem item)
        {
            Product product = ProductItemConverter.Convert(item as ProductItem);
            Repository<Product>.Add(product);
        }

        /// <summary>
        /// Edits existing product
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Edit(IItem item)
        {
            if (item == null)
                return;
            using (var ctx = new ShopContext())
            {
                Product product = ProductItemConverter.Convert(item as ProductItem);

                if (product is null)
                    throw new ArgumentNullException("item is null or can't be converted to Product");
                
                Product oldProduct = ctx.Products.Find(item.Id);

                ctx.Entry(oldProduct).CurrentValues.SetValues(product);
                ctx.SaveChanges();
            }
        }
    }
}
