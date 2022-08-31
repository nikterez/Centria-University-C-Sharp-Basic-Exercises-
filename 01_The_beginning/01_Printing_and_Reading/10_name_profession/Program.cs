using System;

namespace Exercise010
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("I will tell you a story, but i need some info.");
            System.Console.WriteLine("Name the main character:");
            string name = Console.ReadLine();

            System.Console.WriteLine("Give the character a profession");
            string profession = Console.ReadLine();

            System.Console.WriteLine("Once upon a time there was a {1} called {0}.", name, profession);
            System.Console.WriteLine("On her way to work, {0} often pondered what being {1} meant to them.", name, profession);
            System.Console.WriteLine("When you work as a {1} you meet interesting people.", name, profession);
            System.Console.WriteLine("{0} enjoys their work as {1}, The end.", name, profession);

            System.Console.WriteLine("");

            System.Console.WriteLine("Once upon a time there was a {1} called {0}.\n" +
            "On her way to work, {0} often pondered what being {1} meant to them.\n" +
            "When you work as a {1} you meet interesting people.\n" +
            "{0} enjoys their work as {1}, The end.", name, profession);

            System.Console.WriteLine("");

            System.Console.WriteLine("Once upon a time there was a " + profession + " called " + name+".");
            System.Console.WriteLine("On her way to work, " + name + " often pondered what being " + profession + " meant to them.");
            System.Console.WriteLine("When you work as a " + profession + " you meet interesting people.");
            System.Console.WriteLine(name + " enjoys their work as " + profession + ", The end.");


        }
    }
}
