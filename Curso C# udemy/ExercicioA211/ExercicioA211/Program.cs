﻿using System;
using System.Collections.Generic;
using System.IO;
using ExercicioA211.Entities;

namespace ExercicioA211
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> log = new HashSet<LogRecord>();


            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);

                        //Console.WriteLine(line);
                        log.Add(new LogRecord { Username = name, Instant = instant });
                    }

                    Console.WriteLine("Total users: " + log.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
