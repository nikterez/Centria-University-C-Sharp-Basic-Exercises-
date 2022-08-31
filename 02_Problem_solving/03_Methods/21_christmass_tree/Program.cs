using System;

namespace Exercise_021_christmass_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            ChristmassTree(4);
        }
        public static void PrintStars(int input)
        {
            for (int i = 0; i < input; i++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine("");
        }
        public static void PrintSpaces(int input)
        {
            for (var i = 0; i < input; i++)
            {
                System.Console.Write(" ");
            }
        }
        public static void PrintRightTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                PrintSpaces(size - i);
                PrintStars(i);
            }
        }
        public static void ChristmassTree(int height)
        {
            //Triangle
            for (int i = 1; i <= height; i++)
            {
                PrintSpaces(height - i);
                PrintStars(i * 2 - 1);
            }
            //Tree base
            for (int i = 0; i < 2; i++)
            {
                PrintSpaces(height - 2);
                PrintStars(3);
            }
        }
    }
}
