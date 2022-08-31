using System;

namespace Exercise031
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Give number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input % 2 == 0)
            {
                System.Console.WriteLine(input + " is even");
            }
            else
            {
                System.Console.WriteLine(input + " is odd");
            }
        }
    }
}
