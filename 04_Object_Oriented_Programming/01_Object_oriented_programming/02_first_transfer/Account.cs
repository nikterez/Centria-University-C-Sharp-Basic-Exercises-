using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_002_first_transfer
{
    public class Account
    {
        public string accName { get; set; }
        public double accBalance { get; set; }

        public Account(string name, double balance)
        {
            this.accName = name;
            this.accBalance = balance;
        }

        public override string ToString()
        {
            return "Account name: " + this.accName + ", Balance: " + this.accBalance;
        }

        public void Withdrawal(double amount)
        {
            this.accBalance -= amount;
        }

        public void Deposit(double amount)
        {
            this.accBalance += amount;
        }
    }
}