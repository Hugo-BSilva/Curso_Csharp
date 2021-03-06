using System;

namespace ExercicioMatrizesFixação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de linhas: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número de colunas: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
			{
                Console.Write("Digite " + n +" números e de espaço entre eles: ");
                string[] values = Console.ReadLine().Split(' ');
                for (int l = 0; l < n; l++)
			    {
                    matriz[i,l] = Convert.ToInt32(values[l]);
			    }
			}

            //MOSTRA A MATRIZ COMPLETA
            for (int i = 0; i < m; i++)
			{
                for (int j = 0; j < n; j++)
			    {
                    Console.Write(matriz[i,j] + " ");
			    }
                Console.WriteLine("");
			}

            Console.Write("Digite o valor de X: ");
            int x = int.Parse(Console.ReadLine());

            //VERIFICA NA MATRIZ O VALOR DE X
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {                        
                        Console.WriteLine("Posição do X: " + i + " " + j);
                        //Verificação Esquerda
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }

                        //Verificação Direita
                        //se a coluna - 1 for maior que o número do contador do for
                        if (j < n -1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }

                        //Verificação Acima
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i-1, j]);
                        }

                        //Verificação Abaixo
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + matriz[i+1, j]);
                        }
                    }
                }
            }
        }
    }
}
