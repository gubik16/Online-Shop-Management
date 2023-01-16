using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopService
{
    /// <summary>
    /// Manages orders
    /// </summary>
    public class OrderManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>List of all orders</returns>
        public List<Order> GetAllOrders()
        {
            using (var ctx = new ShopContext())
            {
                var orders = ctx.Orders.ToList();

                foreach (var o in orders)
                {
                    o.Address = ctx.Addresses.Find(o.AddressId);
                    o.Customer = ctx.Customers.Find(o.CustomerId);
                    o.OrderItems = ctx.OrderItems.Where(i => i.OrderId == o.OrderId).ToList();
                    foreach (var i in o.OrderItems)
                    {
                        i.Product = ctx.Products.Find(i.ProductId);
                    }
                }

                return orders;
            }
        }

        /// <summary>
        /// Gets order with specified id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Order GetOrderById(int id)
        {
            using (var ctx = new ShopContext())
            {
                var order = ctx.Orders.Find(id);

                order.Address = ctx.Addresses.Find(order.AddressId);
                order.Customer = ctx.Customers.Find(order.CustomerId);
                order.OrderItems = ctx.OrderItems.Where(i => i.OrderId == order.OrderId).ToList();
                foreach (var i in order.OrderItems)
                {
                    i.Product = ctx.Products.Find(i.ProductId);
                }

                return order;
            }
        }

        /// <summary>
        /// Creates new order
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="address"></param>
        /// <param name="products"></param>
        public void CreateOrder(Customer customer, Address address, ICollection<OrderItem> products)
        {
            if (Repository<Customer>.GetById(customer.CustomerId) is null)
                Repository<Customer>.Add(customer);

            if (Repository<Address>.GetById(address.AddressId) is null)
                Repository<Address>.Add(address);

            Order order = new Order()
            {
                AddressId = address.AddressId,
                CustomerId = customer.CustomerId,
                Date = DateTime.Now,
                Status = OrderStatus.Received,
                OrderItems = products
            };

            Repository<Order>.Add(order);
        }

        /// <summary>
        /// Updates order info
        /// </summary>
        /// <param name="order"></param>
        public void UpdateOrder(Order order)
        {
            using (var ctx = new ShopContext())
            {
                var oldOrder = ctx.Orders.Find(order.OrderId);
                ctx.Orders.Remove(oldOrder);

                foreach (var i in order.OrderItems)
                {
                    var product = ctx.Products.Find(i.ProductId);
                    i.Product = product;
                }

                ctx.Orders.Add(order);
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// Changes status of order
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        public void ChangeOrderStatus(int id, OrderStatus status)
        {
            using(var ctx = new ShopContext())
            {
                ctx.Orders.Find(id).Status = status;
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// Deletes order
        /// </summary>
        /// <param name="id"></param>
        public void DeleteOrder(int id)
        {
            using(var ctx = new ShopContext())
            {
                var order = ctx.Orders.Find(id);
                ctx.Orders.Remove(order);
                ctx.SaveChanges();
            }
        }
        /// <summary>
        /// Gets order total price
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public float GetOrderPrice(int id)
        {
            float totalPrice = 0;

            using(var ctx = new ShopContext())
            {
                var items = ctx.OrderItems.Where(i => i.OrderId == id);
                foreach(var item in items)
                {
                    totalPrice += item.Product.Price * item.Quantity;
                }
            }
            return totalPrice;
        }
    }
}
