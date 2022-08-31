using System;

namespace Exercise_012_from_number_to_one
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintFromNumberToOne(5);
        }

        public static void PrintFromNumberToOne(int number)
        {
            for (var i = number; i >=1; i--)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
