using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando uma matriz
            double[,] mat = new double[2, 3];

            //Retorna quantos elementos tem ao total na matriz
            Console.WriteLine(mat.Length);

            //Primeira dimensão da matriz = quantidade de linhas
            Console.WriteLine(mat.Rank);

            //Primeira dimensão da matriz
            Console.WriteLine(mat.GetLength(0));

            //Segunda dimensão da matriz
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
