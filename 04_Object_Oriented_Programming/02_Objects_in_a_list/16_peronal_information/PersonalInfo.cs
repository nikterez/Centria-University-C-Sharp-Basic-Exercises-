using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class PersonalInfo
    {
        public string firstName;
        public string lastName;
        public string id;

        public PersonalInfo(string fName,string lName, string id)
        {
            this.firstName=fName;
            this.lastName=lName;
            this.id=id;
        }

        public override string ToString()
        {
            return this.firstName+" "+this.lastName;
        }
    }


