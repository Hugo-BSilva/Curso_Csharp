using System;
using System.Globalization;


namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faz o cálculo do dia 1 de janeiro do ano 1 da era atual,
             * até os dias de hoje em nanosegundos e retorna os dados atuais */
            //DateTime d1 = DateTime.Now; //Retorna o instante atual do sistema
            //Console.WriteLine(d1);
            //Console.WriteLine(d1.Ticks);

            //Utilizando os Construtores da classe DateTime
            //DateTime d1 = new DateTime(2018, 11, 25);
            //DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 03);
            //DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03, 500);

            ////Usando os Builders
            //DateTime dd1 = DateTime.Now;
            //DateTime dd2 = DateTime.Today;
            //DateTime dd3 = DateTime.UtcNow; //Horário no "GNT" Universal
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(dd1);
            //Console.WriteLine(dd2);
            //Console.WriteLine(dd3);

            //Converte esse texto para data
            //DateTime d1 = DateTime.Parse("2000-08-15");
            //DateTime d2 = DateTime.Parse("2000-08-15 13:05:22");
            //DateTime d3 = DateTime.Parse("10/03/2021");
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);

            //ParseExact, formata a string recebi conforme a máscara que eu colocar
            DateTime d66 = DateTime.ParseExact("2021-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d67 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
       
            Console.WriteLine(d66);
            Console.WriteLine(d67);
        }
    }
}
