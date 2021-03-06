using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //a variavel x é um nullable de double
            //Nullable<double> x = null;
            double? x = null;
            double? y = 10.0;

            /*Operador de coalescência null.
             * A variável i vai receber o valor de x, 
             * mas se x for nulo(??) então ela vai receber o valor de 0.0 */
            double i = x ?? 0.0;

            /*Pega o valor do x, ou então se o valor não existir,
             * pega o valor padrão do tipo da variável x 
             valor padrão do tipo double= 0*/
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //Se dentro variável x existe ou não valor
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("x is null");
            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("y is null");
        }
    }
}
