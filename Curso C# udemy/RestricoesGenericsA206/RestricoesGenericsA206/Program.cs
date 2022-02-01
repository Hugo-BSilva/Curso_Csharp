using RestricoesGenericsA206.Entities;
using RestricoesGenericsA206.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RestricoesGenericsA206
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> listProducts = new List<Products>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            CalculationService calculationService = new CalculationService();

            for (int i = 0; i < n; i++)
            {
                //Esse vetor vai separar o nome do produto do preço
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                listProducts.Add(new Products(name, price));
            }

            Console.WriteLine("MAX: ");
            Console.WriteLine(calculationService.Max(listProducts));
        }
    }
}
