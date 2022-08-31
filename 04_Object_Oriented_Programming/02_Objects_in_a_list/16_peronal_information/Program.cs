using System;
using System.Collections.Generic;

namespace personal_info
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonalInfo> persInfo = new List<PersonalInfo>();
            while (true)
            {
                System.Console.WriteLine("Enter name");
                string input1=Console.ReadLine();
                
                if(input1=="")
                {
                    break;
                }

                System.Console.WriteLine("Enter last name");
                string input2=Console.ReadLine();
                
                System.Console.WriteLine("Enter ID");
                string input3=Console.ReadLine();

                persInfo.Add(new PersonalInfo(input1,input2,input3));
                
            }
            foreach (var item in persInfo)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
