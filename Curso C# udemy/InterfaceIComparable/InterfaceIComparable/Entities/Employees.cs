using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIComparable.Entities
{
    /// <summary>
    /// Funcionários
    /// </summary>
    class Employees : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employees(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + " - Salary: " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            //Se o obj não for um objeto do tipo Employees
            if (!(obj is Employees))
            {
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }

            //Downcasting
            Employees other = obj as Employees;


            //return Name.CompareTo(other.Name); //Ordena por nome(por ordem alfabética)
            return Salary.CompareTo(other.Salary); //Ordena por salário(fazendo a comparação do menor para o maior)
        }
    }
}
