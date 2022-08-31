using System;

namespace Exercise_003_how_many_names
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ada = new Person("Ada Lovelace");
            Person jack = new Person("Jack The Ripper");
            Person mike = new Person("Mike The Incredible Magic Mouse");

            HowManyNames(ada);
            HowManyNames(jack);
            HowManyNames(mike);
        }

        public static void HowManyNames(Person person)
        {           
            string[] parts = person.name.Split(" ");
            int counter = parts.GetLength(0);
            System.Console.WriteLine("{0} has {1} names.",person.name,counter);
        }
    }
}
