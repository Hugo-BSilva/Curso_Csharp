using System;
using System.Globalization;

namespace PropDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime d = new DateTime(2021, 09, 09, 12, 45, 20, 321);

            //Console.WriteLine(d);
            //Console.WriteLine("1) Date: " +d.Date);
            //Console.WriteLine("2) Hour: "+d.Hour);
            //Console.WriteLine("3) Ano: " + d.Year);
            //Console.WriteLine("4) Ticks: " + d.Ticks);
            //Console.WriteLine("5) Day: " + d.Day);
            //Console.WriteLine("6) DayOfWeek: " + d.DayOfWeek);
            //Console.WriteLine("7) DayOfYear: " + d.DayOfYear);
            //Console.WriteLine("8) Kind: " + d.Kind); //Tipo do local / Universão
            //Console.WriteLine("9) Millisecond: " + d.Millisecond);
            //Console.WriteLine("10) Minuts: " + d.Minute);
            //Console.WriteLine("11) Month: " + d.Month);
            //Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay); //É um timeSpan
            //Console.WriteLine("13) Second: " + d.Second);

            //DateTime d = new DateTime(2021, 01, 01, 12, 45, 20, 321);

            //string s2 = d.ToLongTimeString(); //Imprime apenas a hora, convertendo 
            //string s3 = d.ToShortDateString(); //Imprime apenas a data, convertendo
            //string s4 = d.ToShortTimeString(); //Imprime apenas hora e minuto, convertendo
            //string s5 = d.ToString(); //Mostra todos os dados menos o milisegundos, convertendo
            //string s6 = d.ToString("yyyy-MM-dd HH:mm:ss"); //Fazendo uma mascara, para que os dados saiam formatados
            //string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");//Imprime também os milisegundos

            //Console.WriteLine(d.ToLongDateString()); //Ta convertendo a variável DateTime para string
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);
            //Console.WriteLine(s5);
            //Console.WriteLine(s6);
            //Console.WriteLine(s7);

            DateTime d1 = new DateTime(2020, 01, 01, 09, 45, 20, 321);
            DateTime d2 = d1.AddHours(2);
            DateTime d3 = d1.AddMinutes(2);

            DateTime boletoGerado = DateTime.Now;
            DateTime vencimento = boletoGerado.AddDays(7);

            DateTime d = new DateTime(2000, 10, 18);
            DateTime d4 = new DateTime(2000, 10, 25);
            TimeSpan t = d4.Subtract(d);//Subtrai a data d4 pela d

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine("Boleto gerado dia: "+boletoGerado);
            Console.WriteLine("Vencimento do boleto: "+vencimento);
            Console.WriteLine(t);
        }
    }
}
