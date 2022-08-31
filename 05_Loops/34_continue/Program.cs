using System;

namespace Exercise034
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("keep going?");
                string inp = Console.ReadLine();
                
                if (inp == "no")
                {
                    break;
                }
            }
        }
    }
}

