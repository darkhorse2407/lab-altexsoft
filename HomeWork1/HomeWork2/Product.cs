using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Product : Entity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public ProductType? ProductType { get; set; }

        public Product(int id, string name, decimal price, ProductType? productType) : base(id)
        {
            Id = id;
            this.Name = name;
            this.Price = price;
            ProductType = productType;
        }
    }
}
