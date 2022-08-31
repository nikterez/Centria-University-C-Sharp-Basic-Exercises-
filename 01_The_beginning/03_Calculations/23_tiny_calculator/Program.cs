using System;

namespace Exercise023
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
            int minus = num1 - num2;
            int mult = num1 * num2;
            double div = (double)num1 / num2;

            System.Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
            System.Console.WriteLine("{0} - {1} = {2}", num1, num2, minus);
            System.Console.WriteLine("{0} * {1} = {2}", num1, num2, mult);
            System.Console.WriteLine("{0} / {1} = {2}", num1, num2, div);

    }
  }
}
