using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = LeiaNumero("Digite o primeiro numero: ");
            int n2 = LeiaNumero("Digite o segundo numero: ");

            Console.WriteLine();
            try
            {
                Console.WriteLine("{0} / {1} = {2}", n1, n2, n1 / n2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível fazer sua divisão por zero");
            }
            Console.ReadKey();
        }

        static int LeiaNumero(string mensagem)
        {
            int numero = 0;
            bool correto = false;

            do
            {
                try
                {
                    Console.Write(mensagem);
                    numero = Convert.ToInt32(Console.ReadLine());
                    correto = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Você não digitou um número inteiro, tente de novo");
                }
            } while (!correto);            

            return numero;
        }
    }
}
