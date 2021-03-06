using System;

namespace CondicaoTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());
            //Desconto de 10% e 5%
            double desconto = (preco < 20.0) ? desconto = preco * 0.1 : desconto = preco * 0.05;
            Console.WriteLine("Desconto: " + desconto);
        }
    }
}
