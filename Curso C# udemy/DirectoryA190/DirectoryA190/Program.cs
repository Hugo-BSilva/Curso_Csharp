using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryA190
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";

            try
            {
                /*Lista todas as subpastas a partir da pasta myFolder, primeiro passo o caminho da pasta.
                 Depois eu faço o filtro que eu quero, funciona como o cmd do windows/linux
                para procurar arquivos, ou seja *.* vai trazer todas as subpastas*/
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");

                foreach (var item in folders)
                {
                    Console.WriteLine(item);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");

                foreach (var item in files)
                {
                    Console.WriteLine(item);
                }

                Console.Write("Entered the name the new folder: ");
                string newFolder = Console.ReadLine();

                Directory.CreateDirectory(path + "\\" + newFolder);


            }
            catch (IOException e)
            {
                Console.WriteLine("An Error ocurred: " + e.Message);
            }
        }
    }
}
