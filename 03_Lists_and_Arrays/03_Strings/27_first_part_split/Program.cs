using System;

namespace _27_first_part_split
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Part Split");
        
            while (true)
            {
                string input = Console.ReadLine();

                if (input == string.Empty)
                {
                    break;
                }
                string[] parts = input.Split(" ");
                System.Console.WriteLine(parts[0]);
                System.Console.WriteLine("");

            }
        }
    }
}
