using System;

namespace AluguelQuarto
{
    class AlugueldeQuarto
    {
        //Declarando variáveis encapsuladas
        public string Nome { get; set; }
        public string Email { get; set; }

        //CONSTRUTORES
        public AlugueldeQuarto()
        {
        }

        public AlugueldeQuarto(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }

        //MÉTODO DE SOBRECARGA
        public override string ToString()
        {
            return "Nome: " + Nome + ", Email: " + Email;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Criando Um vetor do tipo class
            //int[] numero = new int[1];
            AlugueldeQuarto[] quarto = new AlugueldeQuarto[10];

            Console.Write("Quantos estudantes vão alugar: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Número do quarto: ");
                int numQuarto = int.Parse(Console.ReadLine());
                //Os dados que o usuário digitou, vão ser armazenados na posição do vetor referente ao número do quarto que o usuário digitou
                quarto[numQuarto] = new AlugueldeQuarto { Nome = nome, Email = email };               
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
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
