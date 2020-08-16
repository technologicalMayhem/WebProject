namespace MockShop.Models
{
    public class DeliveryAddress
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int HouseNumber { get; set; }
        public string Country { get; set; }
        public string Notes { get; set; }
    }
}