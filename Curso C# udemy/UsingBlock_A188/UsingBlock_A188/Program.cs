using System;
using System.IO;

namespace UsingBlock_A188
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            #region 1ª Forma
            //try
            //{
            //    //Vai ser automaticamente fechado, graças ao using
            //    using (FileStream fs = new FileStream(path, FileMode.Open))
            //    {
            //        using (StreamReader sr = new StreamReader(fs))
            //        {
            //            while (!sr.EndOfStream)
            //            {
            //                string line = sr.ReadLine();
            //                Console.WriteLine(line);
            //            }
            //        }

            //    }
            //}
            #endregion

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
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
