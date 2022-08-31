using System;

namespace Exercise037
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                System.Console.Write("Give number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }
                else
                {
                    count++;
                    continue;
                }
            }
            System.Console.WriteLine("Negative number count: " + count);
        }
    }
}
