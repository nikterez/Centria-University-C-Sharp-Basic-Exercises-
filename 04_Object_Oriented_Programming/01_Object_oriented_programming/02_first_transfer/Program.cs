using System;

namespace Exercise_002_first_transfer
{
    class Program
    {
        static void Main(string[] args)
        {
            Account heikkisAccount = new Account("Heikki's account", 1000.00);
            Account personalAccount = new Account("Personal account", 0.00);

            Console.WriteLine("Intial state");
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(personalAccount);

            heikkisAccount.Withdrawal(100);
            personalAccount.Deposit(100);

            Console.WriteLine("End state");
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(personalAccount);
        }
    }
}
