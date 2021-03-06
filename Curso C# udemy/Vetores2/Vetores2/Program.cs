using System;

namespace Vetores2
{
    class Product
    {
        public string name { get; set; }
        public double preco { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //declaração de um vetor do tipo referência/class
            Product[] vect = new Product[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome do produto: ");
                string name = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double price = double.Parse(Console.ReadLine());
                //Estou instanciando um vetor do tipo produto, ele vai receber os dados que foi passado por parâmetro
                vect[i] = new Product { name = name, preco = price };            
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].preco;
            }

            double avg = sum / n;

            //o preço médio é::
            Console.WriteLine("Average price: "+avg);
        }
    }
}
