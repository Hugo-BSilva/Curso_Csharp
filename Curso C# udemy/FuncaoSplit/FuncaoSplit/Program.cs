using System;
using System.Globalization;

namespace FuncaoSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {sexo} {idade} {altura}");
        }
    }
}
