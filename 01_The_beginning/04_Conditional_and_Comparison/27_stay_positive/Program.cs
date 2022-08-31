using System;

namespace Exercise027
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Give a number: ");
            int i = Convert.ToInt32(Console.ReadLine());

            if (i > 0)
            {
                System.Console.WriteLine("Positive");
            }
            else
            {
                System.Console.WriteLine("Not positive");
            }
        }
    }
}




