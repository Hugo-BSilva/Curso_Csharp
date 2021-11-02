using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        static string diretorioPadrao = @"c:\temp\myfolder";

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(" ===> INICIANDO PROCESSAMENTO...");
                if (Directory.Exists(diretorioPadrao))
                {
                    var files = Directory.GetFiles(diretorioPadrao);

                    foreach (var file in files)
                    {
                        if (file.Contains(".csv"))
                        {
                            Console.WriteLine($"=> Leitura do arquivo: {file} iniciada...");
                            using (StreamReader sr = new StreamReader(File.OpenRead(file), Encoding.UTF8))
                            {
                                int numlinha = 1;
                                string linha;
                                string[] produtoLinha;

                                string nomeProduto;
                                DateTime dataDeValidade;
                                string valorSTR;
                                double valorProduto;
                                int quantidade;

                                while ((linha = sr.ReadLine()) != null)
                                {
                                    //Dependendo do formato do arquivo, as informações se dividem por , ou ;
                                    produtoLinha = linha.Split(",");


                                    nomeProduto = produtoLinha[0];
                                    valorSTR = produtoLinha[1].Replace("R$ ", "").Trim();
                                    valorProduto = double.Parse(valorSTR.Replace(".", ","));
                                    quantidade = int.Parse(produtoLinha[2]);
                                    double valortotal = valorProduto * quantidade;

                                    Console.WriteLine("Leitura da linha: " + numlinha + $"- Nome: {nomeProduto}" +
                                            $" - Valor do produto: R$: {valorProduto.ToString("F2", CultureInfo.InvariantCulture)}" +
                                            $" - Quantidade: {quantidade}" +
                                            $" - Valor total: R$ {valortotal.ToString("F2", CultureInfo.InvariantCulture)}");
                                    numlinha++;

                                    IEnumerable<string> folders = Directory.EnumerateDirectories(diretorioPadrao, "*.*", SearchOption.AllDirectories);
                                    Directory.CreateDirectory(diretorioPadrao + "\\out");

                                    string nomeArquivo = "summary.csv";


                                    Console.WriteLine($"Arquivo {nomeArquivo} criado com sucesso");
                                    using (StreamWriter sw = File.CreateText(diretorioPadrao + "\\out\\summary.csv"))
                                    {
                                        sw.WriteLine(nomeProduto + "," + valortotal);
                                    }

                                    Console.WriteLine($"Arquivo {nomeArquivo} criado e preenchido com sucesso");



                                }

                                Console.WriteLine("<= Finalizando Leitura de arquivo + arquivo");
                            }
                        }
                    }

                    Console.WriteLine(" <=== FINALIZANDO PROCESSAMENTO");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error ocured: " + e.Message);
            }
        }
    }
}

