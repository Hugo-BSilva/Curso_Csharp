using Exercicio1A199.Entities;
using Exercicio1A199.Services;
using System;
using System.Globalization;

namespace Exercicio1A199
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER CONTRACT DATA");
            Console.Write("Number: ");
            int numberContract = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime dateContract = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            double valueTotalContract = double.Parse(Console.ReadLine());

            Console.Write("Enter number of installments: ");
            int numberInstallments = int.Parse(Console.ReadLine());

            Console.WriteLine("Installments");
            Agreement agreement = new Agreement(numberContract, dateContract);

            PaymentService payment = new PaymentService(numberInstallments, new Agreement(valueTotalContract), new Paypal());

            for (int i = 0; i <= agreement.MonthlyPayment; i++)
            {
                payment.GenerateInstallments(agreement);

                Console.WriteLine(agreement);
            }
        }
    }
}
