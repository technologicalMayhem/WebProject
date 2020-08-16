using System;
using System.Linq;
using MockShop.Models;
using MockShop.Data.Products;

namespace MockShop.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ShopContext context)
        {
            context.Database.EnsureCreated();

            if (context.Products.Any()) return;

            var products = new Product[]
            {
                new Motherboard
                {
                    Category = Category.Motherboards, Description = "Blarg", Price = 7, Stock = 100,
                    ProductName = "ASUS Blargboard", Socket = CpuSocket.Ar, FormFactor = FormFactor.Atx,
                    MemorySlots = 4, PciSlots = 4, SataPorts = 6, MemorySlotGeneration = 3
                },
                new GraphicsCard
                {
                    Category = Category.GraphicsCards, Description = "REALISMS", Memory = 3, Price = 2,
                    DualMode = true, GraphicPower = 9001, ProductName = "KneeForce Gnome GTX"
                }
            };
            context.Products.AddRange(products);
            context.SaveChanges();

            var customers = new[]
            {
                new Customer
                {
                    FirstName = "Johnuithell", LastName = "Dohnus", Balance = 200, DeliveryAddress = new DeliveryAddress
                    {
                        City = "Berlin", Country =
                            "Germany",
                        Street = "Blargoroad", HouseNumber = 5
                    }
                },
                new Customer
                {
                    Balance = 300,
                    FirstName = "Calvin",
                    LastName = "Verheijen",
                    DeliveryAddress = new DeliveryAddress
                        {City = "Maasluis", Country = "Netherlands", Street = "Van Speykstraat", HouseNumber = 11}
                }
            };
            context.Customers.AddRange(customers);
            context.SaveChanges();

            var calvin = context.Customers.First(customer => customer.FirstName == "Calvin");
            var card = context.Products.First(product => product.ProductName == "KneeForce Gnome GTX");
            var orders = new[]
            {
                new Order
                {
                    Customer = calvin, OrderedProducts = new[] {new OrderEntry {Amount = 2, Product = card}},
                    State = OrderState.Placed, CreationDate = DateTime.Now, DeliveryAddress = calvin.DeliveryAddress,
                    EstimatedDelivery = DateTime.Today.AddDays(5)
                }
            };

            context.Orders.AddRange(orders);
            context.SaveChanges();
        }
    }
}