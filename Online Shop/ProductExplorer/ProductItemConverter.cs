using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopService;

namespace Online_Shop
{
    /// <summary>
    /// Converts ProductItem to Product and vice versa
    /// </summary>
    public static class ProductItemConverter
    {
        /// <summary>
        /// Convert ProductItem to Product
        /// </summary>
        /// <param name="i"></param>
        /// <returns>Product object</returns>
        public static Product Convert(ProductItem i)
        {
            Product product = new Product()
            {
                ProductId = i.Id,
                Description = i.Description,
                Img = i.Img,
                Name = i.Name,
                Price = i.Price
            };

            return product;
        }

        /// <summary>
        /// Convert Product to ProductItem
        /// </summary>
        /// <param name="p"></param>
        /// <returns>ProductItem object</returns>
        public static ProductItem Convert(Product p)
        {
            ProductItem product = new ProductItem()
            {
                Id = p.ProductId,
                Description = p.Description,
                Img = p.Img,
                Name = p.Name,
                Price = p.Price
            };

            return product;
        }
    }
}
