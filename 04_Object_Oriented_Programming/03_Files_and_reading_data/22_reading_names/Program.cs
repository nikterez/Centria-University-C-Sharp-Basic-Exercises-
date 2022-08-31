using System;
using System.IO;

namespace _22_reading_names
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Type a file name");
            string input = Console.ReadLine()+".txt";

            System.Console.WriteLine("");
            System.Console.WriteLine(input+":");
            System.Console.WriteLine(File.ReadAllText(input));
        }
    }
}
