using System;

namespace Params2
{
    class Calculator
    {
        //a função soma recebe o vetor de números inteiros, params int (recebe uma quantia variável de valores)
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            //vai percorrer o vetor inteiro somando todos os valores
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel s1 recebe a soma, instanciando um vetor do tipo int e já recebendo os dados 2 e 3
            int s1 = Calculator.Sum(2,3);
            int s2 = Calculator.Sum( 2, 3, 6 );
        }
    }
}
