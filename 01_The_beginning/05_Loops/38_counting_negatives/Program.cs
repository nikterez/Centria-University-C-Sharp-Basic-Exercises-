using System;

namespace Exercise038
{
  public class Program
  {
    public static void Main(string[] args)
    {
            int negativeCount = 0;
            while (true)
            {
                System.Console.Write("Give number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }
                if (num < 0)
                {
                    negativeCount++;
                    continue;
                }
            }
            System.Console.WriteLine("Negative number count: " + negativeCount);
    }
  }
}
