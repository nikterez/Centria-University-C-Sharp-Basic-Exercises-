using System;

namespace Exercise_020_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStars(5);
            PrintStars(3);
            PrintStars(9);
            System.Console.WriteLine("");

            PrintSquare(4);
            System.Console.WriteLine("");

            PrintRectangle(7, 3);
            System.Console.WriteLine("");

            PrintTriangle(4);


        }
        public static void PrintStars(int input)
        {
            for (int i = 0; i < input; i++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine("");
        }

        public static void PrintSquare(int size)
        {
            for (var i = 0; i < size; i++)
            {
                PrintStars(size);
            }
        }

        public static void PrintRectangle(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                PrintStars(width);
            }
        }

        public static void PrintTriangle(int size)
        {
            for (var i = 1; i <= size; i++)
            {
                PrintStars(i);
            }
        }
    }
}
