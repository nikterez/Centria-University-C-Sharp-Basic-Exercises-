using System;

namespace _19_reading_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            
            while (true)
            {   
                Console.WriteLine("Type numbers");
                string input = Console.ReadLine();

                if (input=="end")
                {
                    break;
                }

                count++;
            }

            Console.WriteLine(count);
            

            
        }
    }
}
