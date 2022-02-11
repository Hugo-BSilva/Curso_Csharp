using System;
using System.Collections.Generic;

namespace HashSetSortedSetA208
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine();

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5,6,7,8,9,10 };

            PrintCollection(a);
            PrintCollection(b);

            //union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b); //Vai ser inserido em C os elementos de B que não existem no A 
            PrintCollection(c);

            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b); //Vai ser inserido em D apenas os elementos que contém em A e B
            PrintCollection(d);

            //difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b); //Elimina do A os que estiverem em B(5,6,8,10 serão tirados de A), o resto será adicionado em E
            PrintCollection(e);
        }

        //IEnumerable é uma interface implementada por todas as coleções do Collections.Generic
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
