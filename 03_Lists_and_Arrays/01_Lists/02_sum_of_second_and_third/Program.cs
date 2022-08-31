using System;
using System.Collections.Generic;


namespace _02_sum_of
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int sum = 0;

            while (true)
            {
                System.Console.WriteLine("Enter a number:");
                int input = Convert.ToInt32(Console.ReadLine());


                if (input == 0)
                {
                    break;
                }

                numbers.Add(input);
            }

            sum = numbers[1]+numbers[2];
            System.Console.WriteLine(sum);

        }
    }
}
