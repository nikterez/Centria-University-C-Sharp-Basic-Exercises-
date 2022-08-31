using System;
using System.Collections.Generic;

namespace _06_first_and_last
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            Console.WriteLine("Type a name: ");
            
            while (true)
            {
                string inp = Console.ReadLine();
                if (inp == (""))
                {
                    break;
                }
                names.Add(inp);
            }

            System.Console.WriteLine(names[0]);
            System.Console.WriteLine(names[^1]);
        }
    }
}
