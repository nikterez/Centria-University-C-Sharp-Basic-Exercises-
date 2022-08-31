using System;

namespace Exercise_004_how_many_names_in_person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ada = new Person("Ada Lovelace");
            Person jack = new Person("Jack The Ripper");
            Person mike = new Person("Mike The Incredible Magic Mouse");

            Console.WriteLine(ada + " has " + ada.HowManyNames() + " names.");
            Console.WriteLine(jack + " has " + jack.HowManyNames() + " names.");
            Console.WriteLine(mike + " has " + mike.HowManyNames() + " names.");

        }
    }
}
