using System;

namespace Exercise_014_divisible_in_range
{
    class Program
    {
        static void Main(string[] args)
        {
            DivisibleByThree(1, 10);
        }

        public static void DivisibleByThree(int begin, int end)
        {
            int i = begin;
            while (i <= end)
            {
                if (i % 3 == 0)
                {
                    System.Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
