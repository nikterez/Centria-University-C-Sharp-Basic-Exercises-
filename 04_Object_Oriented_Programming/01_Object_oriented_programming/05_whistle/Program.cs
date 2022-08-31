using System;

namespace Exercise_005_whistle
{
    class Program
    {
        static void Main(string[] args)
        {
            Whistle duckWhistle = new Whistle("Kvaak");
            Whistle roosterWhistle = new Whistle("Peef");

            duckWhistle.Sound();
            roosterWhistle.Sound();
            duckWhistle.Sound();
        }
    }
}
