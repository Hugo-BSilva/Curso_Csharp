using System;
using System.Collections.Generic;
using System.Text;
using HP_Exercicio.Entities.Enums;

namespace HP_Exercicio.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return (Math.Pow(Radius, 2)) * Math.PI;
        }
    }
}
