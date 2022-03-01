using System;
using System.Collections.Generic;

namespace DictionarySortedDictionaryA213
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99999999";
            cookies["user"] = "mariana";
            cookies["adress"] = "brazil";

            Console.WriteLine(cookies["user"]);
            cookies.Remove("adress");
            Console.WriteLine("Many cookies? " + cookies.Count);

            Console.WriteLine("ALL COOKIES:");           

            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
