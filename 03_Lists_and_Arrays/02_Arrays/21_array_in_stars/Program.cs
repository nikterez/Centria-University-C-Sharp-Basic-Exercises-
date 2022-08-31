using System;

namespace _21_array_in_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 1, 3, 4, 2 };
            PrintArrayInStars(numbers);
        }

        public static void PrintArrayInStars(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i]; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine("");
            }
        }
    }
}
