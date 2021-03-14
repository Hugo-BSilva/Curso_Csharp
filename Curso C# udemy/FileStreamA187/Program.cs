using System;
using System.IO;

namespace FileStreamA187
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            //Stream genérica que não faz nenhum tratamento especial pra acessar um recurso de entrada e saída
            FileStream fs = null; 
            //Stream particular otimizada para o que eu preciso
            StreamReader sr = null;

            try
            {
                /* Essas streames são recursos externos, elas conversam com o sistema operacional,
                 esse recurso não é gerenciado pelo clr do .NET. Como eles não pertencem ao clr
                vou precisar fechar isso manualmente */
                //sr = File.OpenText(path)
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                //Enquanto não chegar no final da stream
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error acurred");
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            { //Se o StreamReader estiver aberto
                if (sr != null) sr.Close();
                if (fs != null) sr.Close();
            }

        }
    }
}
