using System;
using System.Collections.Generic;

namespace _09_greatest_number
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

            int max = numbersList[0];
            for (int i = 0; i < numbersList.Count; i++)
            {
                if (numbersList[i] > max)
                {
                    max = numbersList[i];
                }
            }
            System.Console.WriteLine("The greatest number:" + max);

        }
    }
}
