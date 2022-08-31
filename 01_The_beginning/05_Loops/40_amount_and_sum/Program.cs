using System;

namespace Exercise040
{
  public class Program
  {
    public static void Main(string[] args)
    {
            int sum = 0;
            int count = 0;

            while (true)
            {
                System.Console.WriteLine("Give number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 0)
                {
                    break;
                }
                sum += input;
                count++;
            }
            System.Console.WriteLine("Sum: " + sum);
            System.Console.WriteLine("Ammount of numbers: " + count);
    }
  }
}
