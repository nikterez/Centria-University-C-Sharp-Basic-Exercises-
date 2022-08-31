using System;

namespace Exercise_008_card_payments
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentTerminal lunchCafeteria = new PaymentTerminal();
            Console.WriteLine(lunchCafeteria);

            PaymentCard annesCard = new PaymentCard(2);

            Console.WriteLine("amount of money on the card is " + annesCard.balance + " euros");

            bool wasSuccessful = lunchCafeteria.EatLunch(annesCard);
            Console.WriteLine("there was enough money: " + wasSuccessful);

            lunchCafeteria.AddMoneyToCard(annesCard, 100);

            wasSuccessful = lunchCafeteria.EatLunch(annesCard);
            Console.WriteLine("there was enough money: " + wasSuccessful);

            Console.WriteLine("amount of money on the card is " + annesCard.balance + " euros");

            Console.WriteLine(lunchCafeteria);
        }
    }
}
