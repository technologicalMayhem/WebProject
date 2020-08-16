namespace MockShop.Data.Products
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int Sold { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
    }
}