using System;
using System.Collections.Generic;

namespace _05_last_from_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            while (true)
            {
                Console.WriteLine("Type a name: ");
                string inp = Console.ReadLine();
                
                if (inp == (""))
                {
                    break;
                }
                
                names.Add(inp);
            }

            System.Console.WriteLine(names[names.Count-1]);
            System.Console.WriteLine(names[^1]);
        }
    }
}
