using System;

namespace PropTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            //TimeSpan t1 = TimeSpan.MaxValue; //Duração máxima possível de se armazenar num timeSpan
            //TimeSpan t2 = TimeSpan.MinValue;
            //TimeSpan t3 = TimeSpan.Zero;

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);

            //TimeSpan t1 = new TimeSpan(2, 10, 45, 30, 100);

            //Console.WriteLine(t1);
            //Console.WriteLine("Days: " + t1.Days);
            //Console.WriteLine("Hour: "+ t1.Hours);
            //Console.WriteLine("Minute: "+ t1.Minutes);
            //Console.WriteLine("Seconds: "+ t1.Seconds);
            //Console.WriteLine("Miliseconds: "+ t1.Milliseconds);
            //Console.WriteLine("Ticks: "+ t1.Ticks);

            //Console.WriteLine("TotalDays: "+ t1.TotalDays);
            //Console.WriteLine("TotalHours: "+ t1.TotalHours);
            //Console.WriteLine("TotalMinutes: "+ t1.TotalMinutes);
            //Console.WriteLine("TotalSeconds: " + t1.TotalSeconds);
            //Console.WriteLine("TotalMilliseconds: "+ t1.TotalMilliseconds);


            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);
            
            TimeSpan sum = t1.Add(t2); //Somando as hrs de t1 + t2
            TimeSpan dif = t1.Subtract(t2); //Subtraindo as hrs t1 - t2
            TimeSpan mult = t2.Multiply(2.0); //Multiplicando as hrs t2 por 2
            TimeSpan div = t2.Divide(2.0); //Dividindo as hrs t2 por 2
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
