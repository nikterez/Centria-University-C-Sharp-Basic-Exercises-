using System;
using System.Collections.Generic;

namespace _13_finding_names
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            while (true)
            {

                Console.WriteLine("Enter some numbers: ");
                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }

                names.Add(input);
            }

            System.Console.WriteLine("Search for");
            string name = Console.ReadLine();

            bool found = false;
            for (int i = 0; i < names.Count; i++)
            {
                if (name == names[i])
                {
                    System.Console.WriteLine(name + " was found!");
                    found = true;
                }

            }

            if (!found)
            {
                System.Console.WriteLine(name + " was not found!");
            }

        }
    }
}
