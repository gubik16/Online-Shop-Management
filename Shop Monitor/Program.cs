using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_Monitor.ServiceReference;

namespace Shop_Monitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Threading.Thread.Sleep(3000);
            ShopDataServiceClient client = new ShopDataServiceClient();

            ConsoleKeyInfo input;
            do
            {
                Console.WriteLine("1. Create order");
                Console.WriteLine("2. View products");

                input = Console.ReadKey();

                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        client.CreateOrder(CreateOrder());
                        break;
                    case ConsoleKey.D2:
                        ViewProducts(client.GetProducts());
                        break;
                }

                while (Console.ReadKey().Key != ConsoleKey.Escape)
                { }

                Console.Clear();
            } while (input.Key != ConsoleKey.Escape);

            client.Close();
        }

        static Order CreateOrder()
        {
            var address = new Address()
            {
                City = "Szczecin",
                Country = "Poland",
                Street = "ale urwal",
                ZipCode = "69-666",
                HouseNumber = "15b"
            };

            var customer = new Customer()
            {
                FirstName = "Jan",
                LastName = "Kowal",
            };

            var products = new List<OrderItem>();
            var orderitem = new OrderItem()
            {
                ProductId = 3,
                Quantity = 2
            };
            products.Add(orderitem);

            var order = new Order()
            {
                Address = address,
                Customer = customer,
                OrderItems = products.ToArray(),
            };
            return order;
        }

        static void ViewProducts(Product[] products)
        {
            Console.Clear();
            
            foreach(var p in products)
            {
                Console.WriteLine($"{p.ProductId} {p.Name} {p.Price.ToString("c", CultureInfo.CreateSpecificCulture("en-US"))}");
            }
        }
    }
}
