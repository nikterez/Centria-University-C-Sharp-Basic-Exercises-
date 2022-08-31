using System;

namespace Exercise035
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("Give number: ");
                int inp = Convert.ToInt32(Console.ReadLine());

                if (inp == 0)
                {
                    break;
                }
            }
        }
    }
}
