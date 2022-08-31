using System;

namespace Exercise036
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("Give a number: ");
                int inp = Convert.ToInt16(Console.ReadLine());
               
                if (inp == 0)
                {
                    break;
                }
                if (inp < 0)
                {
                    System.Console.WriteLine("This is negative");
                    continue;
                }
                System.Console.WriteLine(inp*inp);
                //System.Console.WriteLine(Math.Pow(inp, 2));
            }
        }
    }
}
