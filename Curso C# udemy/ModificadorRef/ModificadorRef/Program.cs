using System;

namespace ModificadorRef
{
    class Calculator
    {
        //public static void Triple(int x)
        //{//Essa solução não funciona pois o resultado final vai ser armazenado na var x
        //    x = x * 3;
        //}
        
        /*Essa função funciona, 
         * pois o ref vai fazer o parâmetro x se tornar uma refêrencia 
         * para a var original "A" */
        public static void Triple(ref int x)
        {
            x = x * 3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;//No caso do Ref eu sou obrigado a inicializar essa variável atribuindo um valor a ela
            Calculator.Triple(ref a);
            Console.WriteLine(a);

        }
    }
}
