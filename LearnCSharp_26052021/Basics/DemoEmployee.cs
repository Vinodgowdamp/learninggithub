using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_26052021.Basics
{
    class DemoEmployee
    {
        static void Main(string[] args)
        {
            Employee vinod = new Employee();
            vinod.salary = 100;
            vinod.bouns = 200;
            //Added new line
            int vinodsalary = vinod.calculatesalary();
            Console.WriteLine($"vinod's salary is {vinodsalary}");
        }
    }
}
