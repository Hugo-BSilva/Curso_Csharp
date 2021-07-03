using System;
using System.Globalization;
namespace SobreCarga
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //CONSTRUTOR PADRÃO
        public Produto()
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this() //Estou reaproveitando o construtor padrão que recebe quantidade
        {
            Nome = nome;
            Preco = preco;
        }

        //SOBRECARGA
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) //posso reaproveitar o código acima
        {
            Quantidade = quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Produto p = new Produto("tv", 500, 10);

            //Console.WriteLine(p);

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            //p.Nome = Console.ReadLine();
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            //p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /*Console.Write("Quantidade no estoque: ");
            //p.Quantidade = int.Parse(Console.ReadLine());
            int quantidade = int.Parse(Console.ReadLine());*/

            //Depois que o usuário entrou com os 3 dados, aí eu vou instanciar o Produto
            Produto p = new Produto(nome, preco, 20);

            Produto p2 = new Produto(); //Funciona graças ao construtor padrão

            Produto p3 = new Produto
            { //Funciona graças ao construtor padrão
                Nome = "TV",
                Preco = 500.55,
                Quantidade = 100
            };

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos para ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos para ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}

