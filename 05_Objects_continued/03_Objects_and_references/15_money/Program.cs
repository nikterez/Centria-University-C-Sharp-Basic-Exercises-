using System;

namespace Exercise_015_money
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money(100, 60);
            Money moreMoney = new Money(100, 61);

            /*Money combined = money.Plus(moreMoney);

            Console.WriteLine(money);
            Console.WriteLine(moreMoney);
            Console.WriteLine(combined);*/

            Money lessMoney = moreMoney.Minus(money);

            Console.WriteLine(money);
            Console.WriteLine(moreMoney);
            Console.WriteLine(lessMoney);

            /*lessMoney = lessMoney.Minus(money);

            Console.WriteLine(money);
            Console.WriteLine(moreMoney);
            Console.WriteLine(lessMoney);

            Console.WriteLine(lessMoney.LessThan(moreMoney));
            Console.WriteLine(lessMoney.LessThan(money));

            lessMoney = lessMoney.Minus(moreMoney);
            Console.WriteLine(lessMoney);
            */
        }
    }
}
