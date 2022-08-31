using System;

namespace Exercise015
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Give string: ");
            string str = Console.ReadLine();

            System.Console.Write("Give integer: ");
            int i = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Give double: ");
            double d = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("String: " + str);
            System.Console.WriteLine("Integer: " + i);
            System.Console.WriteLine("Doulbe: " + d);

        }
    }
}
