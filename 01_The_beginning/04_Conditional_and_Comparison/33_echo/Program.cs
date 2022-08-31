using System;

namespace Exercise033
{
  public class Program
  {
    public static void Main(string[] args)
    {
      System.Console.WriteLine("Give the first string:");
      string input1 = Console.ReadLine();
      
      System.Console.WriteLine("Give the second string");
      string input2 = Console.ReadLine();
      
      if (input1==input2)
      {
        System.Console.WriteLine("Echo");
      }
      else
      {
        System.Console.WriteLine("Nope!");
      }
    }
  }
}
