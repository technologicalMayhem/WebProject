using System.Collections.Generic;

namespace MockShop.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual DeliveryAddress DeliveryAddress { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}