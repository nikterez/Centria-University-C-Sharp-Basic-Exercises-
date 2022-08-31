using System;

namespace _28_last_part_split
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Last Part Split");

            while (true)
            {   
                string input = Console.ReadLine();

                if (input == string.Empty)
                {
                    break;
                }
                string[] parts = input.Split(" ");
                System.Console.WriteLine(parts[parts.Length - 1]);
                System.Console.WriteLine("");

            }
        }
    }
}
