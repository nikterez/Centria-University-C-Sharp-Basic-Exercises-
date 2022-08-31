using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_009_biggest_pet_shop
{
    public class Person
    {
        public string personName;
        public Pet personPet;

        public Person(string name, Pet pet)
        {
            this.personName = name;
            this.personPet = pet;
        }

        public Person(string name):this(name,new Pet("Toothless","dragon"))
        {
            
        }
        public Person():this("Lilo",new Pet("Stitch","blue alien"))
        {

        }

        public override string ToString()
        {
            return this.personName + ", has a friend called " + this.personPet.ToString();
        }
    }
}