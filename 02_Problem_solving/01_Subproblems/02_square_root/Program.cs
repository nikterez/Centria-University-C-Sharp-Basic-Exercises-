using System;

namespace Exercise_002_square_root
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Give first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Give second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            
            int sum = number1 + number2;
            double sqrt = Math.Sqrt(sum);
            
            System.Console.WriteLine(sqrt);
        }
    }
}
