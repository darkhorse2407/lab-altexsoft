using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Store
    {
        public string Name { get; set; }
        public List<Product> Assortment = new List<Product>();

        public Store(string Name)
        {
            this.Name = Name;
        }
    }
}
