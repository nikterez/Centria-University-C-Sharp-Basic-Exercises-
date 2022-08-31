using System;
using System.Collections.Generic;

namespace _04_counting_names
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            while (true)
            {
                System.Console.WriteLine("Type a word");
                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }

                words.Add(input);
            }

            System.Console.WriteLine("In total: " + words.Count);
        }
    }
}
