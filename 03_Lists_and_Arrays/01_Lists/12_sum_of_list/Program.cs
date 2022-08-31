using System;
using System.Collections.Generic;

namespace _12_sum_of_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int>();

            while (true)
            {

                Console.WriteLine("Enter some numbers: ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == (-1))
                {
                    break;
                }

                numbersList.Add(input);
            }

            int sum = 0;
            for (int i = 0; i < numbersList.Count; i++)
            {
                sum += numbersList[i];
            }

            System.Console.WriteLine("Sum: " + sum);
        }
    }
}
