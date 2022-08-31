using System;

namespace _22_string_three_times
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Type a word");
            string input = Console.ReadLine();
            
            System.Console.WriteLine("{0} {0} {0}",input);
        }
    }
}
