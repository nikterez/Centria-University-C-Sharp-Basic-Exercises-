using System;
using System.Collections.Generic;

namespace _16_remove_last_method
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>();

            strings.Add("First");
            strings.Add("Second");
            strings.Add("Third");

            strings.ForEach(Console.WriteLine);
            System.Console.WriteLine("");


            RemoveLast(strings);
            RemoveLast(strings);

            strings.ForEach(Console.WriteLine);
        }

        public static void RemoveLast(List<string> strings)
        {
            strings.RemoveAt(strings.Count-1);
        }
    }
}
