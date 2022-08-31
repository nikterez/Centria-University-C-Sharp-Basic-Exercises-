using System;

namespace Exercise019
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Give first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Give second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            System.Console.WriteLine("Sum: " + num1 + " + " + num2 + " = " + sum);
            System.Console.WriteLine("Sum: {0} + {1} = {2}", num1, num2, sum);

        }
    }
}
