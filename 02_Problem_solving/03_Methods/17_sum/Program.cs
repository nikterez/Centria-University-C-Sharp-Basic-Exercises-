using System;

namespace Exercise_017_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Sum:" + Sum(4, 3, 6, 1));
        }
        public static int Sum(int num1, int num2, int num3, int num4)
        {
            int sum = 0;
            sum = num1 + num2 + num3 + num4;
            return sum;
        }
    }
}
