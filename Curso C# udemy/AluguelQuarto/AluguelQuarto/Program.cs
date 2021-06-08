using System;

namespace AluguelQuarto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando um vetor do tipo class
            AluguelDeQuarto[] quarto = new AluguelDeQuarto[10];
            int c = 0;

            do
            {
                Console.Write("Quantos estudantes vão alugar? (MÁXIMO 10): ");
                int n = int.Parse(Console.ReadLine());
                c = n;
            } while (c > 10);

            for (int i = 0; i < c; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Número do quarto: ");
                int numQuarto = int.Parse(Console.ReadLine());
                //Os dados que o usuário digitou, vão ser armazenados na posição do vetor referente ao número do quarto que o usuário digitou
                quarto[numQuarto] = new AluguelDeQuarto { Nome = nome, Email = email };
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 1; i <= 10; i++)
            {
                //Se o vetor for diferente/não nulo, ou seja tem algum dado, então mostre os dados para mim
                if (quarto[i] != null)
                {
                    Console.WriteLine(i + " : " + quarto[i]);
                }
            }
        }
    }
}
