using System;
using System.Collections.Generic;

namespace Exercise_013_archive
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Item> itemsList = new List<Item>();
            while (true)
            {
                Console.WriteLine("Identifier? (empty will stop):");
                string id = Console.ReadLine();
                
                if(id=="")
                {
                    break;
                }

                System.Console.WriteLine("Name? (empty will stop):");
                string name = Console.ReadLine();
                
                if (name == "")
                {
                    break;
                }

                Item item = new Item(id,name);

                if (item.CheckDoubleEntry(itemsList))
                {
                    continue;
                }
                itemsList.Add(item);

            }
            System.Console.WriteLine("==Items==");
            foreach (var item in itemsList)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
