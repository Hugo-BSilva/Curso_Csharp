using System;
using System.Collections.Generic;
using System.Text;
using HP_Exercicio.Entities.Enums;

namespace HP_Exercicio.Entities
{
    class Rectangle : Shape
    {
        private Color colors;

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return this.Width * this.Height;
        }
    }
}
