using System;

namespace Exercise032
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Speak friend, and enter!");
            string input = Console.ReadLine();
            if (input == "friend")
            {
                System.Console.WriteLine("Welcome!");
            }
            else
            {
                System.Console.WriteLine("Nope");
            }
        }
    }
}
