using ExercicioManipulacaoArquivosA192.Entities;
using System;
using System.IO;
using System.Text;

namespace ExercicioManipulacaoArquivosA192
{
    /* Fazer um programa para ler o caminho de um arquivo .csv contendo os dados de itens vendidos. Cada item possui
     um nome, preço unitário e quantidade, separados por vírgula. Você deve gerar um novo arquivo chamado "summary.csv",
    localizado em uma subpasta chamada "out" a partir da pasta original do arquivo de origem, contendo apenas o nome
    e o valor total para aquele item(preço unitário multiplicado pela quantidade).*/
    class Program
    {
        static string path = @"c:\temp\myfolder\out\summary.csv";

        static void Main(string[] args)
        {
            string linha, nameProduct, amountSTR;
            string[] productVector;
            double valueProduto, amount;
            int quantidade;
            Product products;
            StringBuilder sb = new StringBuilder();

            try
            {    
                using (StreamReader sr = new StreamReader(File.OpenRead(@"c:\temp\myfolder\file.csv"), Encoding.UTF8))
                {    
                    while ((linha = sr.ReadLine()) != null)
                    {
                        productVector = linha.Split(",");

                        nameProduct = productVector[0];

                        amountSTR = productVector[1].Replace(".", ",");

                        valueProduto = double.Parse(amountSTR);

                        quantidade = int.Parse(productVector[2]);

                        amount = valueProduto * quantidade;

                        products = new Product(nameProduct, amount);
                                                
                        sb.AppendLine(products.Nome_Produto + "," + products.Valor_Total.ToString().Replace(",", "."));
                        Console.WriteLine($"Contents: {products.Nome_Produto} | R$ {amount} | {quantidade}");
                        Console.WriteLine();
                    }

                    Console.WriteLine("Content the file: \n" + sb);

                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(sb);
                        Console.WriteLine("Done! Content entered in file out/summary.csv.");
                        sw.Close();
                    }

                    sr.Close();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error unexpected ocurred: " + e.Message);
            }
        }
    }
}

