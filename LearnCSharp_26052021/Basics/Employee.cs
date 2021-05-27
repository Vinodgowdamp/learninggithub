using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_26052021.Basics
{
    class Employee
    {
        public int salary;
        public int bouns;
        public int calculatesalary ()
        {
           int  totalsalary = salary + bouns;
            return totalsalary;
        }
    }
}
