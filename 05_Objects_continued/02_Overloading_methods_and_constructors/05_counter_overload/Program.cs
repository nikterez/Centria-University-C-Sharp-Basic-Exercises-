using System;

namespace Exercise_005_counter_overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter(5);
            Counter c2 = new Counter();

            System.Console.WriteLine(c1);
            c1.Increase();
            System.Console.WriteLine(c1);
            c1.Increase();
            System.Console.WriteLine(c1);
            c1.Decrease();
            System.Console.WriteLine(c1);
            c1.Increase(10);
            System.Console.WriteLine(c1);
            c1.Decrease(5);
            System.Console.WriteLine(c1);


            c2.Increase();
            c2.Increase();
            c2.Decrease();
            c2.Increase(10);
            c2.Decrease(5);


            
        }
    }
}
