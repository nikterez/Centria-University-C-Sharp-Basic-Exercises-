using System;
using System.IO;

namespace _21_reading_files
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = File.ReadAllText("data.txt");
            System.Console.WriteLine(data);
        }
    }
}
