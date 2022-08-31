using System;

namespace _25_string_split
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("Type some words");
                string input = Console.ReadLine();
                
                System.Console.WriteLine("");
                if (input == string.Empty)
                {
                    break;
                }
                
                string[] parts = input.Split(" ");
                int i = 0;
                
                while (i < parts.Length)
                {
                    System.Console.WriteLine(parts[i]);
                    i++;
                }
                System.Console.WriteLine("");

                continue;

            }
        }
    }
}
