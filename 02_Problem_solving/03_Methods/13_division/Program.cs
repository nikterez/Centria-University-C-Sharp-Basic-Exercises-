using System;

namespace Exercise_013_division
{
    class Program
    {
        static void Main(string[] args)
        {
            Division(10,2);
        }

        public static void Division(int numerator, int denominator)
        {
            double result = (double)numerator / denominator;
            System.Console.WriteLine("{0} / {1} = {2}",numerator,denominator,result);
        }

    }
}
