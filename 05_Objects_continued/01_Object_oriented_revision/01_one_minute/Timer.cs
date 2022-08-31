using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_001_one_minute
{
    public class Timer
    {
        private ClockHand hundredSecond;
        private ClockHand second;

        public Timer()
        {
            this.hundredSecond = new ClockHand(100);
            this.second = new ClockHand(60);
        }

        public override string ToString()
        {
            return this.second + ":" + this.hundredSecond;
        }

        public void Advance()
        {
            this.hundredSecond.Advance();

            if (this.hundredSecond.value == 0)

                this.second.Advance();
        }
    }
}