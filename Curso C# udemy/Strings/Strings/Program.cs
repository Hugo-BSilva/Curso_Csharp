using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string esp = "-------------------------------------";
            string original = "abcde FGHIJ ABC abc DEFG  ";
            string s1 = original.ToUpper(); //Altera todas as letras para maiusculas
            string s2 = original.ToLower(); //Altera todas as letras para minúculas
            string s3 = original.Trim(); //Apaga os espaços em branco entre as palavras, antes e depois

            int n1 = original.IndexOf("bc"); //Pega a primeira ocorrencia da string bc
            int n2 = original.LastIndexOf("bc"); //Pega a última ocorrencia da string bc

            string s4 = original.Substring(3); //Faz um índice começando na posição 3, ou substitui as primeiras 3 letras
            string s5 = original.Substring(3, 5); //A partir da posição 3, pega os 5 caracteres 

            string s6 = original.Replace('a', 'X'); //Troca todo caractere A, pelo caractere x
            string s7 = original.Replace("abc", "xy");//Troca todo caractere abc, pelo caractere xy

            bool b1 = String.IsNullOrEmpty(original); //Testa se o conteúdo da variável original é nulo ou vazio
            bool b2 = String.IsNullOrWhiteSpace(original); //Testa se a variável é nula ou tem muitos espaços em branco

            Console.WriteLine("Original: " + original + "\n ToUpper: " + s1);
            Console.WriteLine(esp);
            Console.WriteLine("Original: " + original + "\n ToLower: " + s2);
            Console.WriteLine(esp);
            Console.WriteLine("Original: " + original + "\n Trim: " + s3);
            Console.WriteLine(esp);
            Console.WriteLine("IndexOf('bc') / primeira ocorrencia do bc: " + n1);
            Console.WriteLine(esp);
            Console.WriteLine("LastIndexOf('bc') / ultima ocorrencia do bc: " + n2);
            Console.WriteLine(esp);
            Console.WriteLine("Substring, a partir da posição 3: " + s4);
            Console.WriteLine(esp);
            Console.WriteLine("Substring, a partir da posição 3, mostre os 5 caracteres: " + s5);
            Console.WriteLine(esp);
            Console.WriteLine("Replace('a','X')Troca o caracter A, pelo X: " + s6);
            Console.WriteLine(esp);
            Console.WriteLine("Replace('abc, xy): " + s7);
            Console.WriteLine(esp);
            Console.WriteLine("IsNullOrEmpty: " + b1 + " False: tem conteúdo, True: está vazia");
            Console.WriteLine(esp);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
