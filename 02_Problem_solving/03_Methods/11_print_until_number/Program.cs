using System;

namespace Exercise_011_print_until_number
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintUntilNumber(5);
        }

        public static void PrintUntilNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
