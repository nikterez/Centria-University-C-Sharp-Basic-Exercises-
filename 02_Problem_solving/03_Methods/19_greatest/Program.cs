using System;

namespace Exercise_019_greatest
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Greatest: " + GreatestOfThree(2, 7, 3));
        }
        public static int GreatestOfThree(int number1, int number2, int number3)
        {
            int greatest = number1;
            if (number2 > greatest)
            {
                greatest = number2;
            }
            if (number3 > greatest)
            {
                greatest = number3;
            }
            return greatest;
        }
    }
}
