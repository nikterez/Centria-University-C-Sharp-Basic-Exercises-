using System;

namespace Exercise_018_smallest
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(SmallestOfTwo(2,7));
        }
        public static int SmallestOfTwo(int number1, int number2)
        {
            int smallest = number1;
            if (number2 < smallest)
            {
                smallest = number2;
            }
            return smallest;
        }

    }
}
