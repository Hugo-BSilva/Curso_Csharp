using System;
using System.Collections.Generic;

namespace Listas1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(); //Criando lista, vazia

            //list.Add(new Product("TV", "radio"));
            list.Add("Maria"); //Add adiciona no final da lista
            list.Add("riq");
            list.Add("joao");
            list.Add("ana");
            list.Add("Joana");
            list.Add("Alex");
            list.Insert(2, "Marco"); //Adiciona o marco na posição 2

            //MOSTRA A LISTA COMPLETA
            foreach(string obj in list)
            {
                Console.WriteLine(obj); 
            }

            Console.WriteLine("List Count: "+ list.Count);//Conta os elementos da lista

            //ENCONTRA O PRIMEIRO RESULTADO COM A LETRA M
            //A expressão LAMBDA x=> x[0] == 'M' representa a função booleana Test no final
            var s1 = list.Find(x => x[0] == 'M');
            Console.WriteLine("First M: "+ s1);

            //ENCONTRA O ÚLTIMO RESULTADO COM A LETRA M
            var s2 = list.FindLast(x => x[0] == 'M');
            Console.WriteLine("Last M: "+ s2);

            //ENCONTRA O PRIMEIRO COM A LETRA M E RETORNA O NÚMERO DA POSIÇÃO
            var index = list.FindIndex(x => x[0] == 'M');
            Console.WriteLine("First position M: "+ index);

            //ENCONTRA O ÚLTIMO COM A LETRA M E RETORNA O NÚMERO DA POSIÇÃO
            var index2 = list.FindLastIndex(x => x[0] == 'M');
            Console.WriteLine("Last position M: "+ index2);

            //CRIEI UMA SEGUNDA LISTA QUE VAI RETORNAR TODOS OS VALORES QUE TEM 5 CARACTERES
            List<string> list2 = list.FindAll(x => x.Length == 5);

            //Dessa forma ele vai percorrer a lista inteira e vai trazer o resultado
            foreach (string obj in list2)
            {
                Console.WriteLine("FindAll 5: " + obj);
            }

            //Eu quero remover a partir da posição 0, remover 1 elementos
            list.RemoveRange(0, 1);
            Console.WriteLine("-------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // Remove pelo número da posição
            list.RemoveAt(3);
            Console.WriteLine("-------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remove apenas o alex
            list.Remove("Alex");
            Console.WriteLine("-------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remove todas as pessoas que começam com a letra M
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-------------------");
            foreach (string obj in list)
            {
                Console.WriteLine("Remove All: " +obj);
            }

            
        }

        //static bool Test(string s)
        //{
        //    return s[0] == 'M';
        //}
    }
}
