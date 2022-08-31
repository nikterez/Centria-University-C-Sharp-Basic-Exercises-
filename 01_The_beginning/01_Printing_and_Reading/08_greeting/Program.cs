using System;

namespace Exercise008
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            System.Console.WriteLine("Hello "+input+"!");
            //System.Console.WriteLine("Hello {0}!",input);
        }
    }
}
