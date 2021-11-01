using ExercicioExcecoesA146.Entities;
using ExercicioExcecoesA146.Entities.Exceptions;
using System;

namespace ExercicioExcecoesA146
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool loop = false;

                do
                {
                    Console.WriteLine(" > Enter account data");

                    Console.Write("Number: ");
                    int numberAccount = int.Parse(Console.ReadLine());
                    Console.Write("Holder: ");
                    string holder = Console.ReadLine();
                    Console.Write("Initial Balance: ");
                    double initialBalance = double.Parse(Console.ReadLine());
                    Console.Write("Withdraw Limit: ");
                    double withDrawLimit = double.Parse(Console.ReadLine());

                    Account account = new Account(numberAccount, holder, initialBalance, withDrawLimit);
                    //Entre com um valor para sacar 
                    Console.WriteLine();
                    Console.Write("Enter amount for whitdraw: ");
                    double amountWithDraw = double.Parse(Console.ReadLine());
                    account.WithDraw(amountWithDraw);
                    //Imprime o valor da conta após o saque
                    Console.WriteLine("New Balance: " + account.Balance);

                    Console.Write("Do you want to do another operation? Y/N: ");
                    string op = Console.ReadLine();
                    Console.Clear();

                    if (string.IsNullOrEmpty(op) || string.IsNullOrWhiteSpace(op)
                        && op.Trim().ToUpper() == "Y" || op.Trim().ToUpper() == "YES")
                    {
                        loop = true;
                    }
                    else
                    {
                        loop = false;
                    }
                } while (loop == false);
            }
            catch (DomainException ex)
            {
                Console.WriteLine("Is not possible to perform the operation: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }            
        }
    }
}
