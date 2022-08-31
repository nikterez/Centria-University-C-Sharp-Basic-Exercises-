using System;

namespace _31_max_name_and_age
{
    class Program
    {
        static void Main(string[] args)
        {
            string maxName = "";
            int maxAge = -1;
            System.Console.WriteLine("CSVNameLenght type name and age:");
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
                string name = parts[0];

                if (age > maxAge)
                {
                    maxAge = age;
                }
                if (name.Length > maxName.Length)
                {
                    maxName = name;
                }


            }
            if (maxAge != -1)
            {
                System.Console.WriteLine("Longest name: {0}", maxName);
                System.Console.WriteLine("Highest age: {0}",2022 - maxAge);
            }
        }
    }
}

