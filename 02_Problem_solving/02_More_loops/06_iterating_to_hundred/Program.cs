using System;

namespace Exercise_006_iterating_to_hundred
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Give a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            while (input <= 100)
            {
                System.Console.WriteLine(input);
                input++;
                //System.Console.WriteLine(input++);

            }
        }
    }
}
