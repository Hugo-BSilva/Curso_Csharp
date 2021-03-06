using System;
using System.Globalization;

namespace SegundoProblema42
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //public void MostrarNaTela()
        //{
        //    Console.WriteLine("-------------------------");
        //    Console.WriteLine("Nome: " + Nome);
        //    Console.WriteLine("Preço: " + Preco);
        //    Console.WriteLine("Quantidade: " + Quantidade);
        //    Console.WriteLine("Valor Total no Estoque: " + ValorTotalEmEstoque());
        //    Console.WriteLine("-------------------------");
        //}

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int qtn) //Não retorna valor, apenas altera o que está armazenado
        {
            //ERROS
            //this.Quantidade += Quantidade;
            //Quantidade += qtn; Estava certo, porém declarei o parâmetro Quantidade e não qtn

            Quantidade = Quantidade + qtn;
        }

        public void RemoverProdutos(int qtn)
        {
            Quantidade -= qtn;
        }
        
        //SOBREPOSIÇÃO
        public override string ToString()
        {
            //return base.ToString();
            Console.Clear();
            Console.WriteLine("-----------------");
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Unidades: "
                + Quantidade
                + ", Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            
        }
    }
}
