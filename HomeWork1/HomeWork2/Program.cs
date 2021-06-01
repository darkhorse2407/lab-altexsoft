using System;
using HomeWork2.UI;
using HomeWork2.BLL;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            var storeUI = new StoreView();
            var orderUI = new OrderView();
            var storesBLL = new StoresBLL();
            var ordersBLL = new OrdersBLL();

            var wallmart = new Store("Wallmart");
            storesBLL.AddProduct(wallmart, new Product(0, "Peperoni", 9.87m, ProductType.Pizza));
            storesBLL.AddProduct(wallmart, new Product(1, "Pork", 15, ProductType.Meat));
            storesBLL.AddProduct(wallmart, new Product(2, "Mountain Dew", 3, ProductType.Drink));
            storesBLL.AddProduct(wallmart, new Product(3, "California", 10, ProductType.Sushi));
            storesBLL.AddProduct(wallmart, 4, "Pear", 3.75m, ProductType.Fruit);
            storeUI.PrintAssortment(wallmart);

            var client1 = new Client(1, "John Doe");

            var order1 = new Order(wallmart, client1);
            ordersBLL.AddProduct(order1, wallmart.Assortment[3]);
            ordersBLL.AddProduct(order1, wallmart.Assortment[4]);
            orderUI.PrintProducts(order1);

            Console.WriteLine(order1.OrderPrice);

            Console.ReadLine();
        }
    }
}
