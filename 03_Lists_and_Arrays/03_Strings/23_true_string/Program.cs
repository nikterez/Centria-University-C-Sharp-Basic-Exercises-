using System;

namespace _23_true_string
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Give a string: ");
            string input = Console.ReadLine();
            
            if(input=="true")
            {
                Console.WriteLine("You got it right");
            }
            else
            {
                Console.WriteLine("Try again");           
            }

        }
    }
}
