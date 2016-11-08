using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;
        //private string address1;

        public string Program
        {
            get
            {
                return program;
            }

            set
            {
                program = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public double Fee
        {
            get
            {
                return fee;
            }

            set
            {
                fee = value;
            }
        }

        //define student object
        public Student (string name, string address, string program, int year, double fee) :base (name, address)
        {
            this.program = program;
            this.Year = year;
            this.fee = fee;
        }

    public override string ToString()
    {
            //return "$"+(Name + Address + program+ year+ fee);

            return base.ToString();
    }
}
}
