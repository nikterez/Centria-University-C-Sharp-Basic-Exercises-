using System;
using System.Collections.Generic;

namespace _14_numbers_in_range
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(2);
            numbers.Add(6);
            numbers.Add(-1);
            numbers.Add(5);
            numbers.Add(1);

            Console.WriteLine("The numbers in the range [0, 5]");
            PrintNumbersInRange(numbers, 0, 5);

            Console.WriteLine("The numbers in the range [3, 10]");
            PrintNumbersInRange(numbers, 3, 10);
        }

        public static void PrintNumbersInRange(List<int> nums, int from, int to)
        {
            List<int> range = new List<int>();

            int i = 0;
            while (i < nums.Count)
            {
                if (nums[i] >= from && nums[i] <= to)
                {
                    range.Add(nums[i]);
                }
                i++;
            }
            if (range.Count > 0)
            {
                range.ForEach(System.Console.WriteLine);
            }
            System.Console.WriteLine("No numbers in range");

        }
    }
}
