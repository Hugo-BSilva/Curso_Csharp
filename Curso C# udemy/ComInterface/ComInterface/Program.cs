using ComInterface.Entities;
using ComInterface.Services;
using System;
using System.Globalization;

namespace ComInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime datePickup = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return (dd/MM/yyyy HH:mm): ");
            DateTime dateReturn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double priceHour = double.Parse(Console.ReadLine());

            Console.Write("Enter price per day: ");
            double priceDay = double.Parse(Console.ReadLine());


            CarRental carRental = new CarRental(datePickup, dateReturn, new Vehicle(carModel));

            //É possível instanciar a classe Brazil pois ela é um subtipo de ITaxService, essa operação acontece por meio de upcasting
            RentalService rentalService = new RentalService(priceHour, priceDay, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
