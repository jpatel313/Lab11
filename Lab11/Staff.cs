using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Staff : Person
    {
        private string school;
        private double pay;

        public string School
        {
            get
            {
                return school;
            }

            set
            {
                school = value;
            }
        }

        public double Pay
        {
            get
            {
                return pay;
            }

            set
            {
                pay = value;
            }
        }

        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.pay = pay;
            this.school = school;
        }




        public override string ToString()
        {
           // return "$" + (Name + Address + school + pay);

            return base.ToString();
            ///TODO modify readable output add fields.
        }

    }
}