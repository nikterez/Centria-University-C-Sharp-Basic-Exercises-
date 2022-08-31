using System;
using System.Collections.Generic;

namespace _11_smallest_and_index
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

            int min = numbersList[0];
            int indexOfMin = 0;
            for (int i = 0; i < numbersList.Count; i++)
            {
                if (numbersList[i] < min)
                {
                    min = numbersList[i];
                }
                if (min == numbersList[i])
                {
                    indexOfMin = i;
                }
            }
 
            System.Console.WriteLine("Min number: " + min);
            System.Console.WriteLine("Found at index: " + indexOfMin);
        }
    }
}
