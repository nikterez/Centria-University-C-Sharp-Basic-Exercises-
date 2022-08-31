using System;

namespace _29_csv_age
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxAge = -1;
            System.Console.WriteLine("Type name and age separated by comma:");
            System.Console.WriteLine("");

            while (true)
            {

                string input = Console.ReadLine();
                if (input == string.Empty)
                {
                    break;
                }
                string[] parts = input.Split(",");
                int age = Convert.ToInt32(parts[1]);
                {
                    if (age > maxAge)
                    {
                        maxAge = age;
                    }
                }

            }
            if (maxAge != -1)
            {
                System.Console.WriteLine("Age of oldest: {0}", maxAge);
            }
        }
    }
}
