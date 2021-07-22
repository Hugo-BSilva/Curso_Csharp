using System;
using System.IO;

namespace StreamWriter_A189
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"c:\temp\file1.txt";
            string targetpath = @"c:\temp\file2.txt";

            try
            {
                //Lê todo conteúdo do arquivo file1 e armazena em um vetor de strings
                string[] lines = File.ReadAllLines(sourcepath);

                //Vai escrever a partir do final do arquivo
                using(StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach (var line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
