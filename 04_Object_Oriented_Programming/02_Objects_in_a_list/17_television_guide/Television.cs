using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace television
{
    public class Television
    {
        public string name;
        public int duration;

        public Television(string name, int duration)
        {
            this.name=name;
            this.duration=duration;
        }

        public override string ToString()
        {
            return this.name+", "+this.duration+" minutes";
        }


    }
}