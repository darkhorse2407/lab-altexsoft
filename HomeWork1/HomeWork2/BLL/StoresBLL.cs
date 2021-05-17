using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.BLL
{
    public class StoresBLL
    {
        public Product GetProduct(Store store, int id)
        {
            return store.Assortment[id];
        }

        public void AddProduct(Store store, Product product)
        {
            store.Assortment.Add(product);
        }

        public void AddProduct(Store store, int id, string name, decimal price, ProductType? productType)
        {
            store.Assortment.Add(new Product(id, name, price, productType));
        }

        public string GetProductName(ProductType? productType)
        {
            return productType switch
            {
                ProductType.None => "None",
                ProductType.Vegetable => "Vegetable",
                ProductType.Fruit => "Fruit",
                ProductType.Pizza => "Pizza",
                ProductType.Meat => "Meat",
                ProductType.Drink => "Drink",
                ProductType.Sushi => "Sushi",
                _ => throw new ArgumentNullException()
            };
        }
    }
}
