using System;

namespace Struct
{
    struct Point
    {
        public double x, y;

        public override string ToString()
        {
            return "( " + x + " , " + y + " )";
        }
    }

    class Program
    {
        static void Main(string[] args)
        { 
            //Essa declaração vai criar as caixas no stack na memória 
            Point p;
            p.x = 10;
            p.y = 20;
            //Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
        }
    }
}
