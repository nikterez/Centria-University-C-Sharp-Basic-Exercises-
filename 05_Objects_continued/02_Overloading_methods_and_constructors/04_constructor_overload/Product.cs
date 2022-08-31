using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_004_constructor_overload
{
    public class Product
    {
        public string name;
        public string location;
        public int weight;

        public Product(string name)
        {
            this.name=name;
            this.location="shelf";
            this.weight=1;
        }

        public Product(string name,string loc)
        {
            this.name = name;
            this.location=loc;
            this.weight=1;
        }

        public Product(string name,int weight)
        {
            this.name = name;
            this.location="warehouse";
            this.weight=weight;
        }

        public override string ToString()
        {
            return this.name+" ("+this.weight+"kg) can be found from the "+this.location+".";
        }
    }
}