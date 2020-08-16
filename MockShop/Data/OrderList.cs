using System;
using System.Collections.Generic;
using System.Linq;
using MockShop.Data.Products;

namespace MockShop.Data
{
    public class OrderList : List<(int, Product)>
    {
        public OrderList(IEnumerable<(int, Product)> collection) : base(collection)
        {
        }

        public string FromList()
        {
            var strings = this.Select(x => $"{x.Item1},{x.Item2.ProductId}");
            return string.Join(";", strings);
        }

        public OrderList ToList(string data, ShopContext context)
        {
            var strings = data.Split(";");
            var contents = strings.Select(x =>
            {
                var content = x.Split(",");
                var amount = Convert.ToInt32(content[0]);
                var product = context.Products.Find(content[1]);
                return (amount, product);
            });
            return new OrderList(contents);
        }
    }
}