using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Order
    {
        private decimal _orderPrice;
        public decimal OrderPrice { get {
                foreach (Product product in Products)
                    _orderPrice += product.Price;
                return _orderPrice;
            } 
            set { }
        }
        public Store Seller { get; set; }
        public Client Client { get; set; }
        public List<Product> Products = new List<Product>();

        public Order(Store seller, Client client)
        {
            this.Seller = seller;
            this.Client = client;
        }
    }
}
