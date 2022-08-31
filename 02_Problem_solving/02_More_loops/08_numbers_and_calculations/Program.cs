using System;

namespace Exercise003
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Give a number: ");
            int sum = 0;
            int count = 0;
            int evenCount = 0;
            int oddCount = 0;
            double avg = 0;
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == -1)
                {

                    break;
                }
                if (input % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }

                sum += input;
                count++;
                avg = (double)sum / count;
            }
            System.Console.WriteLine("Thx! Bye!");
            System.Console.WriteLine("Sum: " + sum);
            System.Console.WriteLine("Numbers: " + count);
            System.Console.WriteLine("Average: " + avg);
            System.Console.WriteLine("Even: " + evenCount);
            System.Console.WriteLine("Odd : " + oddCount);



        }
    }
}