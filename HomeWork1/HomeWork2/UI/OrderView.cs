using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.UI
{
    public class OrderView
    {
        public void PrintClient(Order order)
        {
            Console.WriteLine($"Client: {order.Client.Name}");
        }

        public void PrintSeller(Order order)
        {
            Console.WriteLine($"Seller: {order.Seller.Name}");
        }

        public void PrintProducts(Order order)
        {
            Console.WriteLine("------Your order------");
            foreach (Product product in order.Products)
            {
                Console.WriteLine($"{product.Name} | {product.Price}");
            }
            Console.WriteLine("-----------------------");
        }
    }
}
