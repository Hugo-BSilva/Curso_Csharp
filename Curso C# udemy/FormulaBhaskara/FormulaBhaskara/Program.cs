using System;

namespace FormulaBhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(delta);            
        }
    }
}
