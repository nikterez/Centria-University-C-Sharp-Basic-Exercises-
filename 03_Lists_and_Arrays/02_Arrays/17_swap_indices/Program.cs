using System;

namespace _17_swap_indices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 7, 9 };
            
            foreach (var i in numbers)
            {
                System.Console.WriteLine(i);
            }

            System.Console.WriteLine("Enter two indices: ");
            int inp1 = Convert.ToInt32(Console.ReadLine());
            int inp2 = Convert.ToInt32(Console.ReadLine());

            int temp = numbers[inp1];
            numbers[inp1] = numbers[inp2];
            numbers[inp2] = temp;

            foreach (var i in numbers)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
