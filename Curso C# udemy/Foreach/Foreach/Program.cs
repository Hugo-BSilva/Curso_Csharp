using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "alex", "ana" };

            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("------------------");

            //para cada obj contido no meu vetor vect, imprima obj
            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
