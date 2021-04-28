using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Order
    {
        decimal orderPrice { get; set; }
        Store seller { get; set; }
        Client client { get; set; }
        public List<Product> products = new List<Product>();

        public Order(Store seller, Client client)
        {
            this.seller = seller;
            this.client = client;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public decimal GetOrderPrice()
        {
            foreach(Product product in products)
                orderPrice += product.Price;
            return orderPrice;
        }

        public void GetProducts()
        {
            foreach(Product product in products)
            {
                Console.WriteLine($"{product.Name} | {product.Price}");
            }
        }
    }
}
