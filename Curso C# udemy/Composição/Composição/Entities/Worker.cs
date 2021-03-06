using Composição.Entities.Enums;
using System;
using System.Collections.Generic;

namespace Composição.Entities
{
    class Worker //Classe Trabalhador
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } //Propriedade Department do tipo Department
        //Vai guardar os contratos dos tabalhadores e já vai instanciar a lista para que ela não seja nula
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker()
        {
        }
        //Sempre que tiver uma associação para muitos (LISTA) não vou passar pelo construtor
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)//Quanto que o trabalhador ganhou no mes 
        {
            double sum = BaseSalary;

            //pra cada hourcontract contract na minha lista de Contracts
            foreach (HourContract contract in Contracts)
            {
                //Se esse contrato da minha lista, na data dele . Year for igual a year
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue(); //TotalValue é a operação que retorna o valor do contrato
                }
            }
            return sum;
        }
    }
}
