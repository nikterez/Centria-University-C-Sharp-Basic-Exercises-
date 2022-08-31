using System;

namespace _20_reading_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number to print it's cube: ");
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                int number = Convert.ToInt32(input);
                System.Console.WriteLine(Math.Pow(number, 3));

            }
        }
    }
}
