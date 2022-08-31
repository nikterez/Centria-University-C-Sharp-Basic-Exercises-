using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_002_cube
{
    public class Cube
    {
        public int length;

        public Cube(int edgeLenght)
        {
            this.length = edgeLenght;
        }

        public int Volume()
        {
            int vol = this.length * this.length;
            return vol;
        }

        public override string ToString()
        {
            return "The length of the edge is " + this.length + " and the volume " + this.Volume();
        }


    }
}