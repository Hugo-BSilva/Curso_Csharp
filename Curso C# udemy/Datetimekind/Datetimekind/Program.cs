using System;

namespace Datetimekind
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);//Leva em consideração o horário de Greenwich Mean Time em Londres
            ////DateTime d4 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Unspecified);
            //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            ////Console.WriteLine("Local: "+d1);
            ////Console.WriteLine("Utc: "+d2);
            ////Console.WriteLine("Unspecified: "+d3);
            ////Console.WriteLine(d4);

            //Console.WriteLine("d1: "+ d1);
            //Console.WriteLine("d1 kind: "+d1.Kind);
            //Console.WriteLine("d1 to local: "+d1.ToLocalTime());//Converter para o horario local
            //Console.WriteLine("d1 to utc: "+d1.ToUniversalTime());//Converter para utc
            //Console.WriteLine();
            //Console.WriteLine("d2: " + d2);
            //Console.WriteLine("d2 kind: " + d2.Kind);
            //Console.WriteLine("d2 to local: " + d2.ToLocalTime());
            //Console.WriteLine("d2 to utc: " + d2.ToUniversalTime());
            //Console.WriteLine();
            //Console.WriteLine("d3: " + d3);
            //Console.WriteLine("d3 kind: " + d3.Kind);
            //Console.WriteLine("d3 to local: " + d3.ToLocalTime());
            //Console.WriteLine("d3 to utc: " + d3.ToUniversalTime());

            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15 13:05:58Z"); //Gera o horário no formato UTC(Universal Time)


            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 kind: " + d1.Kind);
            Console.WriteLine("d1 to local: " + d1.ToLocalTime());//Converter para o horario local
            Console.WriteLine("d1 to utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 kind: " + d2.Kind);
            Console.WriteLine("d2 to local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));/*cuidado ! 
            para imprimir uma data no formato ISO 8601, primeiro é preciso garantir que ela esteja
            no formato universal pra depois fazer o ToString*/
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));


        }
    }
}
