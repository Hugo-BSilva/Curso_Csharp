using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();

            Console.WriteLine("Nome 1º Funcionario: ");
            func1.Nome = Console.ReadLine();
            Console.WriteLine("Salario 1º Funcionario: ");
            func1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Nome 2º Funcionario: ");
            func2.Nome = Console.ReadLine();
            Console.WriteLine("Salário 2º Funcionario: ");
            func2.Salario = double.Parse(Console.ReadLine());

            double media = (func1.Salario + func2.Salario) / 2;
            Console.WriteLine("Salario medio: " + media);

        }
    }
}
