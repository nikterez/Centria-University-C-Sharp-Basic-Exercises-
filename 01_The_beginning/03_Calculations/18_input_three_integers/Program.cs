using System;

namespace Exercise018
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Give first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Give second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Give third number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2 + num3;

            System.Console.WriteLine("The sum is {0}", sum);
            System.Console.WriteLine("The sum is " + sum);
        }
    }
}
