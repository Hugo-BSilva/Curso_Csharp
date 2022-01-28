using GenerecisA204.Services;
using System;

namespace GenerecisA204
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;            
            PrintService printService = new PrintService();

            Console.Write("How many values? ");
            int manyValues = int.Parse(Console.ReadLine());            

            for (int i = 0; i < manyValues; i++)
            {
                value = int.Parse(Console.ReadLine());
                printService.AddValue(value);
            }

            int first = printService.First();
            printService.Print();

            Console.WriteLine();
            Console.WriteLine("First: " + first.ToString());

        }
    }
}
