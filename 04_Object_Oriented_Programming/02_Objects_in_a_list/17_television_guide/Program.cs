using System;
using System.Collections.Generic;

namespace television
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Television> prog = new List<Television>();

            while (true)
            {
                Console.WriteLine("Enter program name");
                string input1 = Console.ReadLine();

                if (input1 == "")
                {
                    break;
                }

                System.Console.WriteLine("Enter program duration");
                int input2 = Convert.ToInt32(Console.ReadLine());

                prog.Add(new Television(input1, input2));
            }

            System.Console.Write("Maximum duration? ");
            int input3 = Convert.ToInt32(Console.ReadLine());
            
            
            foreach (Television i in prog)
            {
                if (i.duration<=input3)
                {
                    System.Console.WriteLine(i);
                }
            }

        }
    }
}
