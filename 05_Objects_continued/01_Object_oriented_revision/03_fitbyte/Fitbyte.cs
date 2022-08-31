using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_003_fitbyte
{
    public class Fitbyte
    {
        public int age;
        public double restingHeartRate;
        public double maxHeartRate;

        public Fitbyte(int age, double heartRate)
        {
            this.age=age;
            this.restingHeartRate=heartRate;
            this.maxHeartRate=206.3 - (0.711 * age);    
        }

        public double TargetHeartRate(double percentageOfMaximum)
        {
            return (maxHeartRate - restingHeartRate) * percentageOfMaximum + restingHeartRate;
        }
    }
}