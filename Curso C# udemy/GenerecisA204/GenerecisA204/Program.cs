using GenerecisA204.Services;
using System;

namespace GenerecisA204
{
    class Program
    {
        static void Main(string[] args)
        {
            //Preciso informar o tipo da classe, já que ela é genérica
            PrintService<string> printService = new PrintService<string>();

            Console.Write("How many values? ");
            int manyValues = int.Parse(Console.ReadLine());            

            for (int i = 0; i < manyValues; i++)
            {
                string x = Console.ReadLine();
                printService.AddValue(x);
            }

            string first = printService.First();
            printService.Print();

            Console.WriteLine();
            Console.WriteLine("First: " + first.ToString());

        }
    }
}
