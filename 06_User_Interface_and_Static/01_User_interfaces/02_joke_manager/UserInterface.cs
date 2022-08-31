using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_002_joke_manager
{
    public class UserInterface
    {
        private JokeManager jokes;
        public UserInterface(JokeManager jokes)
        {
            this.jokes = jokes;
        }

        public void Start()
        {
            while (true)
            {
                System.Console.WriteLine("Commands:");
                System.Console.WriteLine(" 1 - add a joke");
                System.Console.WriteLine(" 2 - draw a joke");
                System.Console.WriteLine(" 3 - list jokes");
                System.Console.WriteLine(" x - stop");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    System.Console.WriteLine("Write a joke to be added:");
                    string inputJoke = Console.ReadLine();

                    jokes.AddJoke(inputJoke);
                }

                if (input == "2")
                {
                   System.Console.WriteLine(jokes.DrawJoke());
                }

                if (input == "3")
                {
                    jokes.PrintJokes();
                }

                if (input == "x")
                {
                    break;
                }


            }



        }
    }
}