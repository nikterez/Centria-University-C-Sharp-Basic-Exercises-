using System;

namespace Exercise_009_biggest_pet_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet lucy = new Pet("Lucy", "golden retriever");
            Person leo = new Person("Leo", lucy);

            Person mike = new Person("Mike");

            Person lilo = new Person();

            Console.WriteLine(leo);
            Console.WriteLine(lilo);
            Console.WriteLine(mike);



        }
    }
}
