using System;

namespace ExercicioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número da ordem da matriz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n;

            int[,] mat = new int[n, m];

            for (int i = 0; i < n; i++) //Percorre as linhas
            {
                /*Vetor values recebe .Split baseado no espaço em branco
                to lendo a linha inteira recortando a linha em pedaços de espaço em branco
                e guardando esses pedaços em um vetor chamado values
                 Dentro do for vai percorrer o vetor values guardando os valores na matriz */
                Console.Write("Digite 3 números e de espaço entre eles: ");
                string[] values = Console.ReadLine().Split(' '); //Digite 1 2 3 
                for (int j = 0; j < m; j++) //Percorre as colunas
                {
                    /* Converte o que foi digitado no vetor values para inteiro, e coloca na matriz em
                    sua devida posição */
                    mat[i,j] = Convert.ToInt32(values[j]);
                }
                
            }

            //Main diagonal - mostrando a diagonal principal
            Console.WriteLine("Main Diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i]+" ");
            }

            //Mostrando os números negativos
            int cont = 0;
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < m; y++)
                {
                    if (mat[x, y] < 0)
                    {
                        Console.WriteLine("Números negativos: " + mat[x, y]);
                        cont++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: "+ cont);

        }
    }
}
