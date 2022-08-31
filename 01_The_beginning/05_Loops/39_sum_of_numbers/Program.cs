using System;

namespace Exercise039
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;

            while (true)
            {
                System.Console.WriteLine("Give number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 0)
                {
                    break;
                }
                sum += input;
            }
            System.Console.WriteLine("Sum: " + sum);

        }
    }
}


