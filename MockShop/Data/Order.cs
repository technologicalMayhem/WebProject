using System;
using System.Collections.Generic;
using MockShop.Data.Products;

namespace MockShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EstimatedDelivery { get; set; }
        public virtual DeliveryAddress DeliveryAddress { get; set; }
        public OrderState State { get; set; }
        public virtual ICollection<OrderEntry> OrderedProducts { get; set; }
        public virtual Customer Customer { get; set; }
    }

    public class OrderEntry
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public virtual Product Product { get; set; }
    }

    public enum OrderState
    {
        Placed,
        Processing,
        Delivering,
        Delivered,
        Canceled
    }
}