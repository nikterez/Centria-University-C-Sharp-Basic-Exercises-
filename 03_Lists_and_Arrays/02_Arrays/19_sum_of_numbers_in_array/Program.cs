using System;

namespace _19_sum_of_numbers_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 1, 3, 4, 2 };

            int sum = 0;
            foreach (var i in numbers)
            {
                sum += i;
            }
            System.Console.WriteLine("Sum: " + sum);
        }
    }
}
