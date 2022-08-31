using System;

namespace Exercise_007_where_to_and_from
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write("Where to: ");
            int toNumber = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Where from: ");
            int fromNumber = Convert.ToInt32(Console.ReadLine());
            
            //while
            while (fromNumber <= toNumber)
            {
                System.Console.WriteLine(fromNumber++);
            }

            //for
            /*for (var i = fromNumber; i <= toNumber; i++)
            {
                System.Console.WriteLine(fromNumber++);
            }*/
            
        }
    }
}
