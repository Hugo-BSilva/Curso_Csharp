using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseObject
{
    class Pessoa
    {
        public string Nome;
        public int Telefone;

        public Pessoa(string Nome, int Telefone)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
        }

        //Implementação do método Equals
        public override bool Equals(object obj)
        {
            bool igual = false;
            Pessoa pessoa;
            if (obj is Pessoa)//Se o objeto é da classe pessoa
            {
                pessoa = (Pessoa)obj;//Converte o obj numa Pessoa e armazena na variavel pessoa
                if(this.Nome == pessoa.Nome && this.Telefone == pessoa.Telefone)
                {
                    igual = true;
                }
            }
            return igual;
        }

        public override string ToString()
        {
            return String.Format("Nome: {0}, Telefone: {1}", Nome, Telefone);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("João",123);
            Pessoa p2 = new Pessoa("João",123);

            if (p1 == p2)
            {
                Console.WriteLine("p1 == p2");
            }
            else
            {
                Console.WriteLine("p1 != p2");
            }

            if (p1.Equals(p2))
            {
                Console.WriteLine("P1 é igual a p2");
            }
            else
            {
                Console.WriteLine("p1 é diferente de p2");
            }

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.ReadKey();
        }
    }
}
