using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Product : Entity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public ProductType? ProductType { get; set; }

        public Product(int id, string Name, decimal Price, ProductType? productType) : base(id)
        {
            Id = id;
            this.Name = Name;
            this.Price = Price;
            ProductType = productType;
        }

        public Product(int id) : base(id)
        {

        }

        public override decimal GetFullPrice()
        {
            var value = base.GetFullPrice();
            return value + 20;
        }
    }

    public class Entity
    {
        public int Id { get; set; }

        public Entity(int id)
        {
            Id = id;
        }

        public virtual decimal GetFullPrice()
        {
            return 10;
        }
    }

    class Store
    {
        public string Name { get; set; }
        public List<Product> assortment = new List<Product>();

        public Store(string Name)
        {
            this.Name = Name;
        }

        public void PrintProduct(int id)
        {
            Console.WriteLine($"{assortment[id].Name} | {GetValue(assortment[id].ProductType)} | {assortment[id].Price}");
        }

        public void PrintAssortment()
        {
            foreach(Product product in assortment)
            {
                Console.WriteLine($"{product.Name} | {GetValue(product.ProductType)} | {product.Price}");
            }
        }

        public void AddProduct(Product product)
        {
            assortment.Add(product);
        }

        public void AddProduct(int id, string Name, decimal Price, ProductType? productType)
        {
            var product = new Product(id, Name, Price, productType);
            assortment.Add(product);
        }

        string GetValue(ProductType? productType)
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

    public abstract class PersonAbstract
    {
        public string Name { get; set; }

        public abstract string GetFullname();

        public PersonAbstract(int id)
        {

        }
    }

    public class PersonDerived : PersonAbstract
    {
        public PersonDerived(int id) : base(id)
        {
        }

        public override string GetFullname()
        {
            throw new NotImplementedException();
        }

        public string ReturnValue(ProductType productType)
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

    [Flags]
    public enum ProductType
    {
        None,
        Vegetable,
        Fruit,
        Pizza,
        Meat,
        Drink,
        Sushi
    }
}
