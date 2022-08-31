using System;

namespace Exercise_002_joke_manager
{
    class Program
    {
        static void Main(string[] args)
        {
            JokeManager jList = new JokeManager();
            UserInterface ui = new UserInterface(jList);
            ui.Start();
        }
    }
}
