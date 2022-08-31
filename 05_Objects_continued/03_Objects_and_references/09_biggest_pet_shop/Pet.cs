using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_009_biggest_pet_shop
{
    public class Pet
    {
        public string petName;
        public string petBreed;

        public Pet(string name, string breed)
        {
            this.petName=name;
            this.petBreed=breed;
        }

        public override string ToString()
        {
            return this.petName +" ("+this.petBreed+")";
        }
    }
}