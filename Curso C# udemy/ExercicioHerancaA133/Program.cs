using System;
using ExPropHerancaA133.Entities;
using System.Collections.Generic;

namespace ExPropHerancaA133
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter with products data: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Product common, used or imported? (c/u/i): ");
                char respost = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                
                if (respost == 'i' || respost == 'I')
                {
                    Console.Write("Custom Fee: ");
                    double customFee = double.Parse(Console.ReadLine());

                    ImportedProduct importedProduct = new ImportedProduct(name,price, customFee);
                    products.Add(importedProduct);
                } 
                else if (respost == 'u' || respost == 'U')
                {
                    Console.Write("Manufacture date (yyyy/MM/dd): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    UsedProduct usedProduct = new UsedProduct(name, price, date);
                    products.Add(usedProduct);
                }
                else
                {
                    Product common = new Product(name, price);
                    products.Add(common);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");
            foreach (Product item in products)
            {                
                Console.WriteLine(item.PriceTag());
            }

        }
    }
}
