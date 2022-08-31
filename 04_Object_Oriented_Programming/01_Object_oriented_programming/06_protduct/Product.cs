using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_protduct
{
    public class Product
    {
        public string pName;

        public double pPrice;

        public int pQuantity;

        public Product(string name, double price, int quantity)
        {
            this.pName=name;
            this.pPrice=price;
            this.pQuantity=quantity;
        }

        public override string ToString()
        {
            return this.pName +": price "+this.pPrice+": "+this.pQuantity+" pcs";
        }
    }
}