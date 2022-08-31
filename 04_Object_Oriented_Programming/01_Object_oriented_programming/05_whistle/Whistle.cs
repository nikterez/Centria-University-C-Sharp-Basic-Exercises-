using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_005_whistle
{
    public class Whistle
    {
        private string sound;

        public Whistle(string whistleSound)
        {
            this.sound = whistleSound;
        }

        public void Sound()
        {
            System.Console.WriteLine(this.sound);
        }
    }
}