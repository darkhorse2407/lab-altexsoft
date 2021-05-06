using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Store
    {
        private string Name { get; set; }
        private List<Product> Assortment = new List<Product>();

        public Store(string Name)
        {
            this.Name = Name;
        }

        public string GetStoreName()
        {
            return Name;
        }

        public Product GetProduct(int id)
        {
            return Assortment[id];
        }

        public List<Product> GetAssortment()
        {
            return Assortment;
        }

        public void AddProduct(Product product)
        {
            Assortment.Add(product);
        }

        public void AddProduct(int id, string name, decimal price, ProductType? productType)
        {
            var product = new Product(id, name, price, productType);
            Assortment.Add(product);
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
