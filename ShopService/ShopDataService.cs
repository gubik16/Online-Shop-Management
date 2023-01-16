using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity;

namespace ShopService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ShopDataService : IShopDataService
    {
        /// <summary>
        /// Gets all products from database
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            using(var ctx = new ShopContext())
            {
                foreach(var p in ctx.Products)
                {
                    var product = new Product()
                    {
                        ProductId = p.ProductId,
                        Description = p.Description,
                        Img = p.Img,
                        Name = p.Name,
                        Price = p.Price
                    };
                    products.Add(product);
                }
            }
            return products;
        }

        public void CreateOrder(Order order)
        {
            var orderManager = new OrderManager();
            orderManager.CreateOrder(order.Customer, order.Address, order.OrderItems);
        }
    }
}
