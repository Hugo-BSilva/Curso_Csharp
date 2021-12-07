using Solucao1.Models;
using System;

namespace Solucao1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataHoje = new DateTime(2021,12,07,00,00,01);
            var dataInicio = new DateTime(2019, 12, 06);

            CalculaDiferencaDatas calcular = new CalculaDiferencaDatas(dataHoje, dataInicio);

            Console.WriteLine(calcular);
            

        }
    }
}
