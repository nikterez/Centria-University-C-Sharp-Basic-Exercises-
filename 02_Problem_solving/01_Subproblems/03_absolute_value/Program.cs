using System;

namespace Exercise_003_absolute_value
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Give a number: ");
            int i = Convert.ToInt32(Console.ReadLine());

            if (i < 0)
            {
                System.Console.WriteLine(i*(-1));
                //System.Console.WriteLine(Math.Abs(i));
            }
            else
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
