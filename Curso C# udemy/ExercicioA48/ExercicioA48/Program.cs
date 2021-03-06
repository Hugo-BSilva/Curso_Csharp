using System;

namespace ExercicioA48
{
    class ConversorDeMoeda
    {
        public static double Cotacao;
        public static double Dolares;
        
        public static double Converter()
        {
            double conversao = Cotacao * Dolares;
            double Iof = (Cotacao * Dolares * 6) / 100;
            return conversao + Iof;
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            ConversorDeMoeda.Cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            ConversorDeMoeda.Dolares = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.Converter());
            
            
        }
    }
}
