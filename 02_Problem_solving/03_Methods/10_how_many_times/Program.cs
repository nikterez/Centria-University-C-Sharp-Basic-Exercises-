using System;

namespace Exercise003
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Print how many times?");
            int input = Convert.ToInt32(Console.ReadLine());
            
            int i = 0;

            while (i < input)
            {
                PrintPhrase();
                i++;
            }
        }

        public static void PrintPhrase()
        {
            System.Console.WriteLine("In a hole in the ground there lived a method");
        }
    }
}