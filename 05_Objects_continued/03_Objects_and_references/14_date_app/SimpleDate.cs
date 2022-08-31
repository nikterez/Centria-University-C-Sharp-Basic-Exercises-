using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_014_dating_app
{
    public class SimpleDate
    {
        private int day;
        private int month;
        private int year;

        public SimpleDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void Advance()
        {
            this.day++;
            if (this.day > 30)
            {
                this.day = 1;
                this.month++;
            }

            if (this.month > 12)
            {
                this.month = 1;
                this.year++;
            }

        }


        public void Advance(int howManyDays)
        {
            int addDay = howManyDays % 30;
            int addMonth = howManyDays / 30;
            int addYear = howManyDays/ 360;


            int temp=this.day+addDay;

            if(addYear>0)
            {
                this.day+=addDay-30;
                this.month+=addMonth-12;
                this.year+=addYear;
            }

            /*if(addMonth>0)
            {   
                this.day+=addDay;
                this.month+=addMonth;
            }
            
            if (this.month > 12)
            {
                this.month = 1;
                this.year++;
            }

            if (temp > 30)
            {

                this.day = temp-30;
                this.month++;
            }

            if (this.month > 12)
            {
                this.month = 1;
                this.year++;
            }*/

        }

        /*public SimpleDate AfterNumberOfDays(int days)
        {
            SimpleDate newDate = new SimpleDate();

            // Do something here

            return newDate;
        }*/


        public override string ToString()
        {
            return this.day + "." + this.month + "." + this.year;
        }

        // used to check if this date object (`this`) is before
        // the date object given as the parameter (`compared`)
        public bool Before(SimpleDate compared)
        {
            // first compare years
            if (this.year < compared.year)
            {
                return true;
            }

            // if the years are the same, compare months
            if (this.year == compared.year && this.month < compared.month)
            {
                return true;
            }

            // the years and the months are the same, compare days
            if (this.year == compared.year && this.month == compared.month &&
                this.day < compared.day)
            {
                return true;
            }

            return false;
        }
    }
}
