using System;
using System.Collections.Generic;

namespace _10_index
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

            System.Console.WriteLine("Search for: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (number == numbersList[i])
                {
                    System.Console.WriteLine("{0} is at index: {1}",number,i);
                }
            }

        }
    }
}
