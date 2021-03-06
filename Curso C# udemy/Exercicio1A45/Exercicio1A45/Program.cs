using System;

namespace Exercicio1A45
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalculaArea(double l, double a)
        {
            return l * a;
        }

        public double Perimetro(double l, double a)
        {
            double perimetro = (l * 2) + (a * 2);
            //return 2 * (Largura + altura);
            return perimetro;
        }
        public double Diagonal(double l, double a)
        {
            //double B = Math.Pow(2, larg);//Função de potenciação
            //double A = Math.Pow(2, a);//Função de potenciação
            //double X = A + B;//Função que obtém a raiz quadrada
            //return Math.Sqrt(a);
            return Math.Sqrt(l * l + a * a);
        }

        public override string ToString()
        {
            return "\n" + "Largura: "
                + Largura + "\n"
                + "Altura: "
                + Altura
                + "\n";             

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.Write("Digite a Largura do Retangulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());
            Console.Write("Digite a Altura do Retangulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine());


            Console.WriteLine(retangulo);
            Console.WriteLine("Área: " + retangulo.CalculaArea(retangulo.Largura, retangulo.Altura));
            Console.WriteLine("Perimetro: " + retangulo.Perimetro(retangulo.Largura, retangulo.Altura));
            Console.WriteLine("Diagonal: " + retangulo.Diagonal(retangulo.Largura, retangulo.Altura));
        }
    }
}
