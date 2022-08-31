using System;

namespace _30_csv_name
{
    class Program
    {
        static void Main(string[] args)
        {
            string maxName = "";
            int maxAge = -1;
            System.Console.WriteLine("Type name and age separated by comma:");

            while (true)
            {

                string input = Console.ReadLine();
                
                if (input == string.Empty)
                {
                    break;
                }
                
                string[] parts = input.Split(",");
                int age = Convert.ToInt32(parts[1]);
                string name = parts[0];
                
                {
                    if (age > maxAge)
                    {
                        maxAge = age;
                        maxName = name;
                    }
                }

            }
            if (maxAge != -1)
            {
                System.Console.WriteLine("Name of the oldest: {0}", maxName);
            }
        }
    }
}
