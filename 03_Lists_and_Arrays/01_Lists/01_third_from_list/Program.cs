using System;
using System.Collections.Generic;


namespace _01_third_from_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            while(true)
            {
            System.Console.WriteLine("Enter a string");
            string inp = Console.ReadLine();

            if(inp=="")
            {
                break;
            }
            
            words.Add(inp);
            }

            System.Console.WriteLine(words[2]);
        }
    }
}
