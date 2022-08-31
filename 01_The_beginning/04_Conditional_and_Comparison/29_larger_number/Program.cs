using System;

namespace Exercise029
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Give first number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            System.Console.WriteLine("Give second number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                System.Console.WriteLine("The largest number is " + num1);
            }
            else if (num1 < num2)
            {

                System.Console.WriteLine("The largest number is " + num2);

            }
            else
            {
                System.Console.WriteLine("Equal numbers");
            }

        }
    }
}
