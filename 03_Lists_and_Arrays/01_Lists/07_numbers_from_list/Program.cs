using System;
using System.Collections.Generic;

namespace _07_numbers_from_list
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

            foreach (var number in numbersList)
            {
                System.Console.WriteLine(number);
            }

            //numbersList.ForEach(System.Console.WriteLine);
        }
    }
}
