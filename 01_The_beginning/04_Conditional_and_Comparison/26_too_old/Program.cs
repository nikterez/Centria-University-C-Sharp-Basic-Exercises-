using System;

namespace Exercise026
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Give your year of birth: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year < 1984)
            {
                System.Console.WriteLine("Orwell");
            }
        }
    }
}

