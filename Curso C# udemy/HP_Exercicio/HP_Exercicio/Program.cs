using System;
using System.Collections.Generic;
using System.Globalization;
using HP_Exercicio.Entities;
using HP_Exercicio.Entities.Enums;

namespace HP_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Circle circle;
            int c = 0;
            double width, height, radius;

            do
            {
                Console.Write("Enter the number of shapes(MENOR QUE 10): ");
                int num = int.Parse(Console.ReadLine());
                c = num;
                Console.WriteLine();
            } while (c > 10);

            for (int i = 1; i <= c; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangule or Circle (r/c): ");
                string shape = Console.ReadLine();
                Console.Write("Color (Black/Blue/Red): ");
                Color colors = Enum.Parse<Color>(Console.ReadLine());

                if (shape.ToLower() == "r")
                {                    
                    Console.Write("Width: ");
                    width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    height = double.Parse(Console.ReadLine());
                    list.Add(new Rectangle(width, height, colors));
                    
                } 
                else if (shape.ToLower() == "c"){
                    Console.Write("Radius: ");
                    radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(radius, colors));
                } 
                else
                {
                    Console.WriteLine("OPS, VOCÊ DIGITOU A LETRA ERRADA");
                }

                Console.WriteLine();
                Console.WriteLine("SHAPE AREAS: ");
                foreach (var item in list)
                {
                    Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
