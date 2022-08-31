using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_015_money
{
    public class Money
    {
        private int euros;
        private int cents;

        public Money(int euros, int cents)
        {
            if (cents > 99)
            {
                euros = euros + cents / 100;
                cents = cents % 100;
            }

            if (cents < 0)
            {
                euros--;
                cents=100-Math.Abs(cents);
            }

            this.euros = euros;
            this.cents = cents;
        }

        public Money Plus(Money addition)
        {
            Money newMoney = new Money(this.euros + addition.euros, this.cents + addition.cents);
            return newMoney;
        }

        public Money Minus(Money decreaser)
        {
            if (decreaser.LessThan(this))
            {
                Money newMoney = new Money(this.euros - decreaser.euros, this.cents - decreaser.cents);
                return newMoney;
            }

            Money zero = new Money(0, 00);

            return zero;
        }

        public bool LessThan(Money compared)
        {
            if (this.euros > compared.euros)
            {
                return false;
            }
            else if (this.euros == compared.euros && this.cents > compared.cents)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            string zero = "";
            if (cents < 10)
            {
                zero = "0";
            }

            return this.euros + "." + zero + this.cents + "e";
        }
    }
}