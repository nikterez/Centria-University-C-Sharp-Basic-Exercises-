﻿using System;

namespace Exercise_004_constructor_overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Product tapeMeasure = new Product("Tape measure");
            Product plaster = new Product("Plaster", "home improvement section");
            Product tyre = new Product("Tyre", 5);

            Console.WriteLine(tapeMeasure);
            Console.WriteLine(plaster);
            Console.WriteLine(tyre);
        }
    }
}
