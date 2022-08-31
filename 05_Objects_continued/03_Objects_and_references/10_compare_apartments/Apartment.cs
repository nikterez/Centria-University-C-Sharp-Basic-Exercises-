using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_010_compare_apartments
{
    public class Apartment
    {
        public int apRooms;
        public int apSqFeet;
        public int apPricePerSqFeet;

        public Apartment(int rooms, int area, int price)
        {
            this.apRooms = rooms;
            this.apSqFeet = area;
            this.apPricePerSqFeet = price;
        }
        
        public bool LargerThan(Apartment compared)
        {
            if(this.apSqFeet>compared.apSqFeet)
            {
                return true;
            }
            return false;
        }

        public int PriceDifference(Apartment compared)
        {
            int priceDiff=this.Price()-compared.Price();
            return Math.Abs(priceDiff);
        }

        public bool MoreExpensiveThan(Apartment compared)
        {
            if(this.Price()>compared.Price())
            {
                return true;
            }
            return false;
        }

        private int Price()
        {
            int price = this.apSqFeet*this.apPricePerSqFeet;
            return price;
        }
    }
}