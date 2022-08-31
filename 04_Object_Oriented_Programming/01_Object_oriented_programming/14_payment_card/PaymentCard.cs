using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_014_payment_card
{
    public class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            this.balance=openingBalance;
        }

        public override string ToString()
        {
            return "The card has a balance of "+ this.balance + " euros";
        }
        public void EatLunch()
        {
            if(this.balance>=10.6)
            {
            this.balance-=10.6;
            }
        }

        public void DrinkCoffee()
        {
            if (this.balance >= 2.0)
            {
            this.balance-=2.0;
            }
        }

        public void AddMoney(double amount)
        {
            if(amount>0)
            {
            this.balance+=amount;
            }
        }       
    }
}
