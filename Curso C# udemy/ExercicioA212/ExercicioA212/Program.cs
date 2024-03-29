﻿using ExercicioA212.Entities;
using System;
using System.Collections.Generic;

namespace ExercicioA212
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> set = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int manyStudent = int.Parse(Console.ReadLine());
            for (int i = 1; i <= manyStudent; i++)
            {
                int registration = int.Parse(Console.ReadLine());
                set.Add(new Student { Registration = registration });
            }

            Console.Write("How many students for course B? ");
            manyStudent = int.Parse(Console.ReadLine());
            for (int i = 1; i <= manyStudent; i++)
            {
                int registration = int.Parse(Console.ReadLine());
                set.Add(new Student { Registration = registration });
            }

            Console.Write("How many students for course C? ");
            manyStudent = int.Parse(Console.ReadLine());
            for (int i = 1; i <= manyStudent; i++)
            {
                int registration = int.Parse(Console.ReadLine());
                set.Add(new Student { Registration = registration });
            }

            Console.WriteLine("Total Students: " + set.Count);
        }
    }
}
