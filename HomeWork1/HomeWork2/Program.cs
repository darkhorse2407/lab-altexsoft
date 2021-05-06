using System;
using HomeWork2.UI;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            var storeUI = new StoreView();
            var orderUI = new OrderView();
            var product1 = new Product(0, "Peperoni", 9.87m, ProductType.Pizza);
            var product2 = new Product(1, "Pork", 15, ProductType.Meat);
            var product3 = new Product(2, "Mountain Dew", 3, ProductType.Drink);
            var product4 = new Product(3, "California", 10, ProductType.Sushi);

            var store1 = new Store("Wallmart");
            store1.AddProduct(product1);
            store1.AddProduct(product2);
            store1.AddProduct(product3);
            store1.AddProduct(product4);
            store1.AddProduct(4, "Pear", 3.75m, ProductType.Fruit);
            storeUI.PrintAssortment(store1);

            var client1 = new Client(1, "John Doe");

            var order1 = new Order(store1, client1);
            order1.AddProduct(store1.GetProduct(3));
            order1.AddProduct(store1.GetProduct(4));
            orderUI.PrintProducts(order1);

            Console.WriteLine(order1.OrderPrice);

            Console.ReadLine();
        }


        public record ProductRecord(int Id);
    }
}
