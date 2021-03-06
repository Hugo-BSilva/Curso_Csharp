using System;

namespace Timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            //TimeSpan t1 = new TimeSpan(0, 1, 30);//0horas 1min 30seg
            //Console.WriteLine(t1);
            //Console.WriteLine(t1.Ticks);//Mostra o tempo em nanosegundos

            //TimeSpan t1 = new TimeSpan();
            //TimeSpan t2 = new TimeSpan(900000000L);
            //TimeSpan t3 = new TimeSpan(2, 11, 21);
            //TimeSpan t4 = new TimeSpan(1, 2, 11, 21); //Dia e Hora
            //TimeSpan t5 = new TimeSpan(19, 05, 30, 55, 400);//Dia hora, minuto, segundo e milisegundo

            //Console.WriteLine(t1);
            //Console.WriteLine("00:01:30 em Ticks: " + t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);

            TimeSpan t1 = TimeSpan.FromDays(1.5); //Quero instanciar um timespan de um dia e meio
            TimeSpan t2 = TimeSpan.FromHours(1.5);//Quero instanciar um timespan de uma hora e meia
            TimeSpan t3 = TimeSpan.FromMinutes(1.5);//Quero instanciar um timespan de um minuto e meio
            TimeSpan t4 = TimeSpan.FromSeconds(1.5);//Quero instanciar um timespan de um segundo e meio
            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);//Quero instanciar um timespan de um milisegundo e meio
            TimeSpan t6 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
        }
    }
}
