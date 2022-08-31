using System;

namespace Exercise_004_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Give first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Give second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                System.Console.WriteLine("{0} is greater than {1}", num1, num2);
            }
            else if (num1 < num2)
            {
                System.Console.WriteLine("{1} is greater than {0}", num1, num2);

            }
            else
            {
                System.Console.WriteLine("{0} and {1} are equal", num1, num2);

            }
        }
    }
}
