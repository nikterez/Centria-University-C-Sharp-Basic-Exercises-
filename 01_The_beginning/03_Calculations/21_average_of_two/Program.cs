﻿using System;

namespace Exercise021
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Give first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Give second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            double avg = (double)sum / 2;

            System.Console.WriteLine("The average is: " + avg);
        }
    }
}
