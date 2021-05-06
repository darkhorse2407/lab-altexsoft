using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.UI
{
    public class StoreView
    {
        public void PrintProduct(Store store, int id)
        {
            Console.WriteLine($"{store.GetProduct(id).Name} | {store.GetProductName(store.GetProduct(id).ProductType)} | {store.GetProduct(id).Price}");
        }

        public void PrintAssortment(Store store)
        {
            foreach (Product product in store.GetAssortment())
            {
                Console.WriteLine($"{product.Name} | {store.GetProductName(product.ProductType)} | {product.Price}");
            }
        }

        public void PrintStoreName(Store store)
        {
            Console.WriteLine($"Store name: \"{store.GetStoreName()}\"");
        }
    }
}
