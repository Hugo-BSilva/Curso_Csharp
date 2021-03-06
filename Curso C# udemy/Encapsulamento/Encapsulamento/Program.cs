using System;
using System.Globalization;

namespace Encapsulamento
{
    class Produto
    {
        //OS ATRIBUTOS DEVEM TER _x COMEÇANDO COM LETRA MINÚSCULA
        private string _nome;
        private int _quantidade;
        //IMPLEMENTANDO AUTO PROPRIEDADE 
        public double Preco { get; private set; }        

        //CONSTRUTOR PADRÃO
        public Produto()
        {
        }
        //CONSTRUTOR QUE RECEBE PARÂMETROS
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            _quantidade = quantidade;
        }

        //CRIANDO PROPERTIE OU PROPRIEDADE Nome, que vai receber os métodos get e sets
        public string Nome
        {
            get { return _nome; }
            set { /*No setNome teria que passar um atributo nome, 
                e fazer a condição, no caso o atributo value pode fazer esse papel*/
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        //Propriedade usada caso não estiver implementado a auto propriedade
        //public double Preco
        //{
        //    get { return _preco; }
        //}
        public int Quantidade
        {
            get { return _quantidade; }
        }

        #region
        ////MÉTODOS GET-OBTER E SET-DEFINIR
        //public string GetNome()
        //{
        //    return _nome;
        //}
        //public void SetNome(string nome)
        //{ //SÓ VOU ACEITAR O NOME SE ELE NÃO FOR VAZIO E TIVER MAIS DE UM CARACTERE
        //    if (nome != null && nome.Length > 1)
        //    {
        //        _nome = nome;
        //    }
        //    else
        //    {
        //        Console.Write("Digite novamente: ");
        //    }
        //}

        

        /* Só vou criar os métodos get para preço e quantidade 
         * pois eu quero que o usuário altere apenas pelos outros métodos */
        //public double GetPreco()
        //{
        //    return _preco;
        //}
        //public int GetQuantidae()
        //{
        //    return _quantidade;
        //}

        #endregion
        public double ValorTotalEmEstoque()
        {
            return Preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("tv", 500, 2);
            //graças ao método SetNome é possível fazer a linha abaixo
            //p.SetNome("TV 4k");
            //Console.WriteLine(p.GetNome());
            p.Nome = "TV hd";

            Console.WriteLine(p.Nome);
        }
    }
}
