using System;

namespace dalmatian
{
    class Program
    {
        static void Main(string[] args)
        {
            Dalmatian a = new Dalmatian("Zoe",54);
            System.Console.WriteLine("{0} is a vary good dog. She has {1} darker spots in her fur",a.name,a.spots);
        }
    }
}
