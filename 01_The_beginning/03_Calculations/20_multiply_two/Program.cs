using System;

namespace Exercise020
{
  public class Program
  {
    public static void Main(string[] args)
    {
            System.Console.WriteLine("Give first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Give second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int mult = num1 * num2;

            System.Console.WriteLine("Multiply: " + num1 + " * " + num2 + " = " + mult);
            System.Console.WriteLine("Multiply: {0} * {1} = {2}", num1, num2, mult);

    }
  }
}
