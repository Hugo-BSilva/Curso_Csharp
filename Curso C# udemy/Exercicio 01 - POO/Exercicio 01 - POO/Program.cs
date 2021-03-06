using System;

namespace Exercicio_01___POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.Write("Digite o nome da primeira pessoa: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Digite a idade da primeira pessoa: ");
            p1.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.Write("Digite o nome da segunda pessoa: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Digite a idade da segunda pessoa: ");
            p2.Idade = Convert.ToInt32(Console.ReadLine());

            if(p1.Idade > p2.Idade)
            {
                Console.Clear();
                Console.WriteLine("Pessoa mais velha: "+p1.Nome);
            } else if(p2.Idade > p1.Idade)
            {
                Console.Clear();
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }

        }
    }
}
