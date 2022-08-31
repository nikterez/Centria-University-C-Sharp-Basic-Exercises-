using System;

namespace Exercise024
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Your speed: ");
            int speed = Convert.ToInt32(Console.ReadLine());
            
            if (speed > 120)
            {
                System.Console.WriteLine("Speeding!");
            }
        }
    }
}
