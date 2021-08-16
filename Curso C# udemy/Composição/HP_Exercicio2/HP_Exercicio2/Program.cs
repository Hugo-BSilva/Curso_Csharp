using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using HP_Exercicio2.Entities;

namespace HP_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();
            Console.Write("Enter the number of tax payers: ");
            int numPayers = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= numPayers; i++)
            {
                double health = 0;
                int employees = 0;

                Console.WriteLine($"Tax Payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char typePayer = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                

                if (typePayer.ToString().ToLower() == "i" )
                {
                    Console.Write("Health Expenditures: ");
                    health = double.Parse(Console.ReadLine());
                    list.Add(new PessoaFisica(health, name, anualIncome));
                }
                else if (typePayer.ToString().ToLower() == "c")
                {
                    Console.Write("Number of Employees: ");
                    employees = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(employees, name, anualIncome));
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double result = 0;

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Nome}: $ " + item.CalcularImposto().ToString("F2", CultureInfo.InvariantCulture));
                result = result + item.CalcularImposto();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ "+ result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
