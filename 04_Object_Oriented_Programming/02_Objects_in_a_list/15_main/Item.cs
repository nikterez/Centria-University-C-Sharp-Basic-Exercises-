using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Item
{
    public class Item
    {
        public string name;
        public string created = new DateTime().ToString();


        public Item(string name)
        {
            this.name = name;
            this.created = DateTime.Now.ToString("dd.MM.yyyy HH.mm.ss");
        }

        public override string ToString()
        {
            return this.name + " (created at: " + this.created + ")";
        }
    }
}