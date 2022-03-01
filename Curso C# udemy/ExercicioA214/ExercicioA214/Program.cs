using System;
using System.Collections.Generic;
using System.IO;

namespace ExercicioA214
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string candidate = line[0];
                        int vote = int.Parse(line[1]);

                        if (dictionary.ContainsKey(candidate))
                        {
                            dictionary[candidate] += vote;
                        }
                        else
                        {
                            dictionary[candidate] = vote;
                        }
                    }
                    foreach (KeyValuePair<string, int> item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
