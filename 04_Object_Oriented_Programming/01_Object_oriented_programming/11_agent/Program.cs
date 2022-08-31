using System;

namespace _11_agent
{
    class Program
    {
        static void Main(string[] args)
        {
            Agent a = new Agent("James", "Bond");
            Agent b = new Agent("Jason", "Bourne");

            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
        }
    }
}
