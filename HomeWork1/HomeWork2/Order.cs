using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Order
    {
        private decimal Order_Price { get; set; }
        public decimal OrderPrice { get {
                foreach (Product product in Products)
                    Order_Price += product.Price;
                return Order_Price;
            } 
        }
        private Store Seller { get; set; }
        private Client Client { get; set; }
        private List<Product> Products = new List<Product>();

        public Order(Store seller, Client client)
        {
            this.Seller = seller;
            this.Client = client;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public Client GetClient()
        {
            return Client;
        }

        public Store GetSeller()
        {
            return Seller;
        }

        public List<Product> GetProducts()
        {
            return Products;
        }
    }
}
