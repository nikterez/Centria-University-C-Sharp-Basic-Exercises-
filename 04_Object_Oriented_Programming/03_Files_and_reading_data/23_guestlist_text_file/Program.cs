using System;
using System.IO;

namespace _23_guestlist_text_file
{
    class Program
    {
        static void Main(string[] args)
        {   
            System.Console.WriteLine("Name of file: ");
            string file = Console.ReadLine();
            System.Console.WriteLine("");
            
            System.Console.WriteLine("Enter names, an empty line quits.");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }

                string[] names = File.ReadAllLines(file);
                bool found = false;

                foreach (var name in names)
                {
                    if (input == name)
                    {
                        System.Console.WriteLine("The name is on the list");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    System.Console.WriteLine("The name is not on the list");
                }

            }


        }
    }
}
