using System;

namespace _20_print_neatly
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 1, 3, 4, 2 };
            PrintNeatly(numbers);

        }

        public static void PrintNeatly(int[] array)
        {
            System.Console.WriteLine(String.Join(", ", array));
        }
    }
}
