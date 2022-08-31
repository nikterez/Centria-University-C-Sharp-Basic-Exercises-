using System;

namespace Exercise030
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Give your percent [0-100]");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 < 0)
            {
                System.Console.WriteLine("Impossible");
            }
            else if (num1 < 50)
            {
                System.Console.WriteLine("Fail");
            }
            else if (num1 < 60)
            {
                System.Console.WriteLine("1");
            }
            else if (num1 < 70)
            {
                System.Console.WriteLine("2");
            }
            else if (num1 < 80)
            {
                System.Console.WriteLine("3");
            }
            else if (num1 < 90)
            {
                System.Console.WriteLine("4");
            }
            else if (num1 <= 100)
            {
                System.Console.WriteLine("5");
            }
            else
            {
                System.Console.WriteLine("Outstanding!");
            }

        }
    }
}
