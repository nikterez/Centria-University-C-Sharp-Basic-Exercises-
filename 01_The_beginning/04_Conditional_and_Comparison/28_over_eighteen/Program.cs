using System;

namespace Exercise028
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Give a number: ");
            int i = Convert.ToInt32(Console.ReadLine());

            if (i <= 17)
            {
                System.Console.WriteLine("You are underage");
            }
            else
            {
                System.Console.WriteLine("You are an adult");
            }
        }
    }
}
