using Interfaces.Entities;
using System;
using System.Globalization;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime datePickup = DateTime.ParseExact(
                Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture
            );

            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime dateReturn = DateTime.ParseExact(
                Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture
            );

            Console.Write("Enter price per hour:");
            double priceHour = double.Parse(Console.ReadLine());

            Console.Write("Enter price per day: ");
            double priceDay = double.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(
                datePickup, dateReturn, new Vehicle(carModel)
            );


            Console.Write("INVOICE: ");
            Console.Write("Basic payment: ");
            Console.WriteLine("Tax: ");
            Console.WriteLine("Total payment: ");

        }
    }
}
