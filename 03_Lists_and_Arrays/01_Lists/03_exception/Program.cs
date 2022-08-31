using System;
using System.Collections.Generic;

namespace _03_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers= new List<string>{"one", "two", "three","four","five"};

            System.Console.WriteLine(numbers[5]);
        }
    }
}
