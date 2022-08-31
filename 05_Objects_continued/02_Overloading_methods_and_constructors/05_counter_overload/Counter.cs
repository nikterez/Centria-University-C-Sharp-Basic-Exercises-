using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_005_counter_overload
{
    public class Counter
    {
        public int value { get; set; }

        public Counter(int value)
        {
            this.value = value;
        }

        public Counter()
        {
            this.value = 0;
        }

        public void Increase()
        {
            this.value++;
        }

        public void Increase(int increaseBy)
        {
            if (increaseBy > 0)
            {
                this.value += increaseBy;
            }
        }

        public void Decrease()
        {
            this.value--;
        }

        public void Decrease(int decreaseBy)
        {
            if (decreaseBy > 0)
            {
                this.value -= decreaseBy;
            }
        }

        public override string ToString()
        {
            return "Value: "+this.value;
        }


    }
}