using System;

namespace Exercise_001_second_power
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Give a number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            
            System.Console.WriteLine(i*i);
            //System.Console.WriteLine(Math.Pow(i, 2));
        }
    }
}
