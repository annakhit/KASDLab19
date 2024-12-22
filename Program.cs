using System;
using System.Collections.Generic;
using System.IO;

namespace KASDLab19
{
    internal class Program
    {
        static void Main()
        {
            string[] rows = File.ReadAllLines("../../Data/input.txt");

            HashSet<string> keySet = HTMLParser.Parse(rows).KeySet();
            MyHashMap<string, int> biekcia = HTMLParser.Parse(rows);

            Console.WriteLine($"Tags count: {keySet.Count}") ;

            foreach (string key in keySet) Console.WriteLine($"Tag: {key} Count: {biekcia.Get(key)}");
           
            Console.ReadKey();
        }
    }
}
