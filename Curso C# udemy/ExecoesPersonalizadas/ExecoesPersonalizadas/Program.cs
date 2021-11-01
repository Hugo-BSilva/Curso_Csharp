using ExecoesPersonalizadas.Entities;
using ExecoesPersonalizadas.Entities.Exceptions;
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
            try
            {
                Console.WriteLine(" > Welcome to Hotel ! < ");
                Console.Write("Room number the to reservation: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check-in Date: ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out Date: ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

                Console.WriteLine("Reservation: " + reservation);


                Console.Write("Update Check-in Date: ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Update Check-out Date: ");
                checkOut = DateTime.Parse(Console.ReadLine());
                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine($"Update Reservation: {reservation}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error in reservation: {e}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                //Erro inesperado + mensagem do erro
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}

