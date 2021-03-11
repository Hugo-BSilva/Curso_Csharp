using System;
using System.Collections.Generic;
using ExHerancaA131.Entities;
namespace ExHerancaA131
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n): ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (outsourced == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double addCharge = double.Parse(Console.ReadLine());
                    OutSourceEmployee employeeOutSource = new OutSourceEmployee(name, hours, valuePerHour, addCharge);
                    employees.Add(employeeOutSource);
                } 
                else 
                { 

                Employee employ = new Employee(name, hours, valuePerHour);
                employees.Add(employ);
                }
                Console.WriteLine();
            }

            foreach (Employee item in employees)
            {
                Console.WriteLine("PAYMENTS: ");
                Console.WriteLine("Nome: "+ item.Name + " - $ " + item.Payment());
            }

            Console.ReadKey();
        }
    }
}
