using System;
using System.Collections.Generic;
using System.Text;
using HP_Exercicio.Entities.Enums;
using HP_Exercicio.Entities.Enums;

namespace HP_Exercicio.Entities
{
    abstract class Shape
    {
        private Color color;

        public Color Color { get; set; }

        protected Shape(Color color)
        {
            this.color = color;
        }

        public abstract double Area();
    }
}
