using System;

namespace Exercicio3A45
{
    class Aluno
    {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double NotaFinal()
        {
            return nota1 + nota2 + nota3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.nome = Console.ReadLine();

            Console.Write("Primeira nota: ");
            aluno.nota1 = double.Parse(Console.ReadLine());
            Console.Write("Segunda nota: ");
            aluno.nota2 = double.Parse(Console.ReadLine());
            Console.Write("Terceira nota: ");
            aluno.nota3 = double.Parse(Console.ReadLine());

            double resultado = aluno.NotaFinal();

            if (resultado >= 60)
            {
                Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal());
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal());
                Console.WriteLine("REPROVADO");
                resultado = 60 - resultado;
                Console.WriteLine("FALTARAM "+resultado+" PONTOS");
            }


        }
    }
}
