﻿using InterfaceIComparable.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace InterfaceIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\teste\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employees> employeeList = new List<Employees>();

                    //Enquanto não chegar ao final do arquivo, execute.
                    //While not reach the end of the file, run.
                    while (!sr.EndOfStream)
                    {
                        employeeList.Add(new Employees(sr.ReadLine()));
                    }

                    //Ordena a lista em ordem alfabética
                    //Sort the list in alphabetical order
                    employeeList.Sort();
                    foreach (Employees employee in employeeList)
                    {
                        Console.WriteLine(employee);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred with the file.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
