using System;

namespace Exercise014
{
  public class Program
  {
    public static void Main(string[] args)
    {
      System.Console.WriteLine("Give me the truth");
      bool b = Convert.ToBoolean(Console.ReadLine());
      System.Console.WriteLine(b);
      System.Console.WriteLine(!b);
    }
  }
}
