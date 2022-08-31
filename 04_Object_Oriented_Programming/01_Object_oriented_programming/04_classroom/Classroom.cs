using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_004_classroom
{
    public class Classroom
    {
        private string code;
        private int seats;

        public Classroom(string classCode, int seatsNumber)
        {
            this.code=classCode;
            this.seats=seatsNumber;
        }
    }
}