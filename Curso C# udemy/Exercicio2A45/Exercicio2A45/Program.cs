using System;

namespace Exercicio2A45
{
    class Funcionario
    {
        public string nome;
        public double salarioBruto;
        public double imposto;

        public double SalarioLiquido()
        {
            return salarioBruto - imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            salarioBruto = salarioBruto + (salarioBruto * porcentagem / 100);
        }

        public override string ToString()
        {
            return " >>> Dados do Funcionário <<< " + "\n" +
                "Nome: " + nome +
                ", Salário: R$ " + SalarioLiquido();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome do Funcionário: ");
            func.nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func.salarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            func.imposto = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine(func);

            Console.Write("Digite a porcentagem para aumentar o salario: ");            
            double porcentagem = double.Parse(Console.ReadLine());
            func.AumentarSalario(porcentagem);

            Console.WriteLine(func);
        }
    }
}
