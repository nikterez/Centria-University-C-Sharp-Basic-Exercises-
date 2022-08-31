using System;

namespace Exercise016
{
  public class Program
  {
    public static void Main(string[] args)
    {
      System.Console.WriteLine("How many days?");
      int days = Convert.ToInt32(Console.ReadLine());
      System.Console.WriteLine(days*86400);
    }
  }
}
