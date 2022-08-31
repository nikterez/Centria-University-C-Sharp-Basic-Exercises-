using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_008_card_payments
{
    public class PaymentTerminal
    {
        private double money;  // amount of cash
        private int coffeeAmount; // number of sold coffees
        private int lunchAmount;  // number of sold lunches

        public PaymentTerminal()
        {
            // register initially has 1000 euros of money
            this.money=1000;
        }

        public double DrinkCoffee(double payment)
        {
            // an coffee now costs 2.50 euros
            // increase the amount of cash by the price of an coffee mean and return the change
            // if the payment parameter is not large enough, no coffee is sold and the method should return the whole payment
            double change = payment-2.50;
            if(payment>=2.50)
            {
                this.coffeeAmount++;
                this.money+=payment-change;
                return change;
            }
            return payment;
        }

        public double EatLunch(double payment)
        {
            // a lunch now costs 10.30 euros
            // increase the amount of cash by the price of a lunch and return the change
            // if the payment parameter is not large enough, no lunch is sold and the method should return the whole payment
            double change = payment - 10.30;
            if (payment >= 10.30)
            {
                this.lunchAmount++;
                this.money += payment - change;

                return change;
            }
            return payment;
        }

        public bool DrinkCoffee(PaymentCard card)
        {
            // a coffee costs 2.50 euros
            // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
            // otherwise false is returned
            if (card.TakeMoney(2.50) == true)
            {
                coffeeAmount++;
                return true;
            }
            return false;
        }

        public bool EatLunch(PaymentCard card)
        {
            // a lunch costs 10.30 euros
            // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
            // otherwise false is returned
            if(card.TakeMoney(10.30)==true)
            {
                lunchAmount++;
                return true;
            }
            return false;

        }

        public void AddMoneyToCard(PaymentCard card, double sum)
        {
            // ...
            card.AddMoney(sum);
        }

        public override string ToString()
        {
            return "money: " + money + ", number of sold coffees: " + coffeeAmount + ", number of sold lunches: " + lunchAmount;
        }
    }
}
