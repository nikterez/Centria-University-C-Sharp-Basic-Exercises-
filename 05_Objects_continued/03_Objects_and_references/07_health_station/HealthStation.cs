using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_007_health_station
{
    public class HealthStation
    {

        public int weighings { get; private set; }

        public HealthStation()
        {
            
        }

        public int Weigh(Person p)
        {
            weighings++;
            return p.weight;
        }

        public void Feed(Person p)
        {
            p.weight++;
        }


    }
}