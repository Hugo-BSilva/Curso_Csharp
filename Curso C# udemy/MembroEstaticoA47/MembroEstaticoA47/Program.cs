using System;

namespace MembroEstaticoA47
{
    class Program
    {
        static void Main(string[] args)
        {         
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString());
            Console.WriteLine("Volume: "+ vol.ToString());
            Console.WriteLine("Valor de Pi: "+ Calculadora.Pi.ToString());
        }
    }
}
