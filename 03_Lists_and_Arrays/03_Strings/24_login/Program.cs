using System;

namespace _24_login
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter username: ");
            string user = Console.ReadLine();

            System.Console.WriteLine("Enter password: ");
            string pass = Console.ReadLine();

            if (user == "alex" && pass == "sunshine")
            {
                System.Console.WriteLine("You have successfully loged in");
            }

            else if (user == "emma" && pass == "haskel")
            {
                System.Console.WriteLine("You have successfully loged in");

            }

            else
            {
                System.Console.WriteLine("Incorrect username or password");
            }
        }
    }
}
