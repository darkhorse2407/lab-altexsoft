using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.BLL
{
    public class OrdersBLL
    {
        public void AddProduct(Order order, Product product)
        {
            order.Products.Add(product);
        }
    }
}
