using System;
using System.Globalization;
using System.Collections;
using Composição.Entities;
using Composição.Entities.Enums;
/* Ler os dados de um trabalhador com N contratos(N fornecido pelo usuário).
 * Depois, solicitar do usuário um mês e mostrar qual foi o salário do funcionário nesse mês, conforme exemplo.
 09-enumeracoes-composicao(para-anotacoes) */
namespace Composição
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: "); //Nome do departamento
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: "); //Dados do trabalhador

            Console.Write("Name: "); //Nome
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): "); //Nível do trabalhador
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: "); //Salário Base
            double baseSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? "); //Quantos contratos para esse trabalhador ?
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                string data = Console.ReadLine();
                DateTime date = DateTime.Parse(data);
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration: ");
                int time = int.Parse(Console.ReadLine());

                //Instanciando um contrato
                HourContract contract = new HourContract(date, valuePerHour, time);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            //Entre com mes e ano para calcular quanto que o trabalhador ganhou no mes 
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthandYear = Console.ReadLine();
            //Vai pegar duas posições do que o usuário digitar a partir da posição 0 ou seja o início
            int month = int.Parse(monthandYear.Substring(0, 2));
            //Vai pegar da posição 3 até o final da string
            int year = int.Parse(monthandYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: "+ worker.Department.Name);
            Console.WriteLine($"Income for {monthandYear}: "+ worker.Income(year,month));

        }
    }
}
