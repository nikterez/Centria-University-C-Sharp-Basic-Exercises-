using System;
using System.Collections.Generic;

namespace Item
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Item> items = new List<Item>();
            while (true)
            {
                System.Console.WriteLine("Enter name");
                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }
                items.Add(new Item(input));

            }
            foreach (var i in items)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
