using System;

namespace ModificadorOut
{
    class Calculator
    {
        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
            //out triple = origin * 3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a=10;
            int triple;
            //out triple é a variável de saída que vai armazenar o resultado.
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
