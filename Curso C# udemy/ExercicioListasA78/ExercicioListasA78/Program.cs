using System;
using System.Collections.Generic;
using System.Globalization;
namespace ExercicioListasA78
{
    class Funcionarios
    {
        public int ID { get; set; }
        public string  Name { get; set; }
        public double Salary { get; set; }

        public Funcionarios()
        {
        }
        public Funcionarios(int id, string nome, double salario)
        {
            this.ID = id;
            this.Name = nome;
            this.Salary = salario;
        }

        public double IncreaseSalary(double p)
        {
            return Salary += Salary * p / 100.0;
        }

        public override string ToString()
        {
            return "------------------ \n" 
                + "ID: " + ID + "\n"+
                "Name: " + Name + "\n"+
                "Salary: " + Salary +
                "\n ------------------";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios func = new Funcionarios();
            List<Funcionarios> lista = new List<Funcionarios>();

            Console.Write("How many employees will be registered ? \n Quantos empregados deseja registrar? ");
            int qtn = Convert.ToInt16(Console.ReadLine());

            //CADASTRO DOS EMPREGADOS
            int[] registro = new int[qtn];

            for (int i = 0; i < qtn; i++)
            {
                Console.WriteLine("Employee " + i + " #");
                Console.Write(" ID: ");
                int ID = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Name: ");
                string Name = Console.ReadLine();
                Console.Write(" Salary: ");
                double Salary = double.Parse(Console.ReadLine());
                lista.Add(new Funcionarios(ID, Name, Salary));
            }

            //MOSTRA TODOS OS EMPLOYEES CADASTRADOS
            foreach (Funcionarios item in lista)
            {
                Console.WriteLine(item);
            }

            //Entre com o id do funcionário que vai ter o salário aumentado
            Console.Write("Enter the emplyee id that will have salary increase: ");
            int pesquisaID = Convert.ToInt32(Console.ReadLine());
            //Procura o funcionário com o ID que o usuário digitou
            Funcionarios search = lista.Find(x => x.ID == pesquisaID);
            

            if (search != null)
            {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine());
                search.IncreaseSalary(percent);
            }
            else
            {
                Console.WriteLine("this id does not exists.");
            }

            //MOSTRA TODOS OS EMPLOYEES CADASTRADOS
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Funcionarios obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
