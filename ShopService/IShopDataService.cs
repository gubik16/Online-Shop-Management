using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShopService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IShopDataService
    {
        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        void CreateOrder(Order order);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ShopService.ContractType".
    [DataContract]
    public class Product
    {
        [DataMember] public int ProductId { get; set; }
        [DataMember] public string Name { get; set; }
        [DataMember] public float Price { get; set; }
        [DataMember] public string Description { get; set; }
        [DataMember] public byte[] Img { get; set; }
        [NotMapped] public string ProductInfo
        {
            get
            {
                return $"Id: {ProductId} Name: {Name}";
            }
        }

        [DataMember] public virtual ICollection<OrderItem> OrderItems { get; set; }
    }

    [DataContract]
    public class OrderItem
    {
        [DataMember] public int OrderItemId { get; set; }
        [DataMember] public int Quantity { get; set; }

        [DataMember] public int ProductId { get; set; }
        [DataMember] public virtual Product Product { get; set; }

        [NotMapped]
        public string ProductName { get { return Product.Name; } }

        [DataMember] public int OrderId { get; set; }
        [DataMember] public virtual Order Order { get; set; }
    }

    [DataContract]
    public class Address
    {
        [DataMember] public int AddressId { get; set; }
        [DataMember] public string Country { get; set; }
        [DataMember] public string City { get; set; }
        [DataMember] public string ZipCode { get; set; }
        [DataMember] public string Street { get; set; }
        [DataMember] public string HouseNumber { get; set; }

        [DataMember] public virtual ICollection<Order> Orders { get; set; }
    }

    [DataContract]
    public class Customer
    {
        [DataMember] public int CustomerId { get; set; }
        [DataMember] public string FirstName { get; set; }
        [DataMember] public string LastName { get; set; }

        [DataMember] public virtual ICollection<Order> Orders { get; set; }
    }

    [DataContract]
    public class Order
    {
        [DataMember] public int OrderId { get; set; }
        [DataMember] public DateTime Date { get; set; }
        [DataMember] public OrderStatus Status { get; set; }

        [DataMember] public int CustomerId { get; set; }
        [DataMember] public virtual Customer Customer { get; set; }

        [DataMember] public virtual ICollection<OrderItem> OrderItems { get; set; }

        [DataMember] public int AddressId { get; set; }
        [DataMember] public virtual Address Address { get; set; }

        [NotMapped]
        public string OrderInfo
        {
            get
            {
                return $"Id: {OrderId}   Customer: {Customer.FirstName} {Customer.LastName}   Date: {Date.ToShortDateString()} {Date.ToShortTimeString()}   Status: {Status}";
            }
        }
    }

    [DataContract]
    public enum OrderStatus
    {
        [EnumMember] Received,
        [EnumMember] Prepared,
        [EnumMember] Sent,
        [EnumMember] Finished,
        [EnumMember] Canceled
    }
}
