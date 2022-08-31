using System;

namespace _26_string_contains_av
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Split if word contains \"av\"");
            
            while (true)
            {
                string input = Console.ReadLine();
                System.Console.WriteLine("");

                if (input == string.Empty)
                {
                    break;
                }
                
                string[] parts = input.Split(" ");
                
                for (var i = 0; i < parts.Length; i++)
                {
                    if (parts[i].Contains("av"))
                    {
                        System.Console.WriteLine(parts[i]);
                        System.Console.WriteLine("");
                    }
                }
            }
        }
    }
}
