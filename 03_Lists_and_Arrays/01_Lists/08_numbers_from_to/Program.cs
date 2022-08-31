using System;
using System.Collections.Generic;

namespace _08_numbers_from_to
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

            System.Console.WriteLine("From where");
            int from = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Where to");
            int to = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("");

            int i = 0;
            while (i < numbersList.Count)
            {
                if (numbersList[i] > from && numbersList[i] < to)
                {
                    System.Console.WriteLine(numbersList[i]);
                }
                i++;
            }
        }
    }
}
