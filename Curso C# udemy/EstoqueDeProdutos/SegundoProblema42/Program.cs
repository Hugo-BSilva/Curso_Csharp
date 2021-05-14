using System;

namespace SegundoProblema42
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Produto prod = new Produto();
            int op = 0;

            do
            {
                Console.Clear();
                Console.Write("Nome do Produto:");
                prod.Nome = Console.ReadLine();
                Console.Write("Preço do Produto:");
                prod.Preco = double.Parse(Console.ReadLine());
                Console.Write("Quantidade do Produto:");
                prod.Quantidade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dados do produto: " + prod);
                Console.WriteLine("-------------------------");
                //prod.MostrarNaTela();

                int item = 0;
                Console.WriteLine("Deseja Adicionar um item ? / DIGITE 1");
                Console.WriteLine("Deseja Remover um item ? / DIGITE 2");
                Console.Write("R: ");

                item = Convert.ToInt32(Console.ReadLine());

                if(item == 1)
                {
                    Console.WriteLine("-------------------------");
                    Console.Write("Digite a quantidade que deseja colocar:  ");
                    int qte = int.Parse(Console.ReadLine());
                    prod.AdicionarProdutos(qte);
                    Console.WriteLine("DADOS ATUALIZADOS: " + prod);
                    Console.WriteLine("-------------------------");
                } 
                else if (item == 2)
                {
                    Console.WriteLine("-------------------------");
                    Console.Write("Digite a quantidade que deseja colocar:  ");
                    int qte = int.Parse(Console.ReadLine());
                    prod.RemoverProdutos(qte);
                    Console.WriteLine("DADOS ATUALIZADOS: " + prod);
                    Console.WriteLine("-------------------------");
                }
                else
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Deseja Adicionar Produto no Estoque ?");
                    Console.Write("(se sim digite 1, se não digite 2) :  ");
                    op = Convert.ToInt32(Console.ReadLine());
                }
                
            } while (op == 1);
        }
    }
}
