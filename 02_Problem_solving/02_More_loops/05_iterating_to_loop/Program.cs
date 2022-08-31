using System;

namespace Exercise_005_iterating_to_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Give a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            
            for (var i = 0; i <= input; i++)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
