using Repositories;
using System;
using System.Collections.Generic;

namespace ProductModuleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * code here is not mandatory but will help 
             * to understand flow better
             */
             Dictionary<int, string> ProductDictionary2 = new Dictionary<int, string>();

            ProductRepository Items = new ProductRepository(11, "Kettle", ProductDictionary2);
            Items.AddProduct("Apple", 1);
            Items.AddProduct("Ball", 2);
            Items.AddProduct("Curtain", 3);
            Items.AddProduct("Doll", 4);
            Items.AddProduct("EnergyDrink", 5);
            Items.AddProduct("FaceWash", 6);
            Items.AddProduct("GameConsole", 7);
            Items.AddProduct("Hat", 8);
            Items.AddProduct("InkPen", 9);
            Items.AddProduct("Jug", 10);
            if (Items.RemoveProduct(1))
            {
                Console.WriteLine("That product is available and is been removed");
            }
            else
            {
                Console.WriteLine("The Product was not found");
            }
            if (Items.RemoveProduct(19))
            {
                Console.WriteLine("That product is available and is been removed");
            }
            else
            {
                Console.WriteLine("The Product was not found");
            }
            if (Items.GetProduct(2))
            {
                Console.WriteLine("The Product is found");

            }
            else
            {
                Console.WriteLine("The Product was not found");
            }
            if (Items.GetProduct(18))
            {
                Console.WriteLine("The Product is found");

            }
            else
            {
                Console.WriteLine("The Product was not found");
            }
            if (Items.GetProduct("Curtain"))
            {
                Console.WriteLine("The Product is found");

            }
            else
            {
                Console.WriteLine("The Product was not found");
            }
            if (Items.GetProduct("pen"))
            {
                Console.WriteLine("The Product is found");

            }
            else
            {
                Console.WriteLine("The Product was not found");
            }

            foreach (var things in Items.GetAllProducts())
            {
                Console.WriteLine($"Product ID:{things.Key}, Product name:{things.Value}");
            }
        }
    }
}