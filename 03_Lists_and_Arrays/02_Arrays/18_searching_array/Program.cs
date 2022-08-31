using System;

namespace _18_searching_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 12, 20, 29 };

            System.Console.WriteLine("Enter number to search for: ");
            int inp = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            for (var i = 0; i < numbers.Length; i++)
            {
                if (inp == numbers[i])
                {
                    System.Console.WriteLine("{0} is at index {1}", inp, i);
                    found = true;
                }
            }
            
            if (!found)
            {
                System.Console.WriteLine("{0} was not found",inp);
            }
        }
    }
}
