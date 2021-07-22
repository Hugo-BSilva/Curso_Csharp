using System;
using System.IO; 

namespace FilesA186
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Caminho do arquivo de origem
            string sourcePath = @"c:\temp\file1.txt";

            //Caminho do arquivo de destino
            string targetPath = @"c:\temp\file2.txt";

            try 
            {
                //Instancio o objeto que vai estar associado ao caminho passando por sourcePath
                FileInfo fileinfo = new FileInfo(sourcePath);
                fileinfo.CopyTo(targetPath);

                //vai ler o arquivo armazendo o conteúdo no vetor lines
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
