using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_013_archive
{
    public class Item
    {
        public string itemIdentifier;
        public string itemName;

        public Item(string identifier, string name)
        {
            this.itemIdentifier = identifier;
            this.itemName = name;
        }

        public override string ToString()
        {
            return this.itemIdentifier + ": " + this.itemName;
        }

        public bool CompareTo(Item item)
        {

            if (this.itemIdentifier == item.itemIdentifier)
            {
                return true;
            }
            return false;
        }

        public bool CheckDoubleEntry(List<Item> list)
        {
            foreach (var item in list)
            {
                if (this.CompareTo(item))
                {
                    return true;
                }
            }
            return false;

        }
    }
}