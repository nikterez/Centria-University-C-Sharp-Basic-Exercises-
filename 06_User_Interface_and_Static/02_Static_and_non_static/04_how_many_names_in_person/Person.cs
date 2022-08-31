using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_004_how_many_names_in_person
{
    public class Person
    {
        public string name;

        public Person(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }

        public int HowManyNames()
        {
            string[] parts = this.name.Split(" ");
            int counter = parts.GetLength(0);
            return counter;
        }
    }
}