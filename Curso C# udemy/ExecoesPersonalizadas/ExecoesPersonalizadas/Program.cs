using ExecoesPersonalizadas.Entities;
using System;

namespace ExecoesPersonalizadas
{
    /* Reserva de Hotel
      - Alterações de reserva só podem ocorrer para datas futuras
      - A data de saída deve ser maior que a data de entrada*/
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine(" > Welcome to Hotel ! < ");

            Console.Write("Room number the to reservation: ");
            int roomNumber = int.Parse(Console.ReadLine());

            Console.Write("Check-in Date: ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out Date: ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date.");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.Write("Check-in Date: ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out Date: ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpdateDates(checkIn, checkOut);

                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + error);
                }

            }          
        }
    }
}
