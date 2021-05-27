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
            int[] arr = new int[5];
            arr[0] = 12;
            arr[1] = 22;
            arr[2] = 33;
            arr[3] = 55;
            arr[4] = 66;
            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }

            Employee vinod = new Employee();
            vinod.salary = 100;
            vinod.bouns = 200;
            //Added new line
            //Added in local
            int vinodsalary = vinod.calculatesalary();
            Console.WriteLine($"vinod's salary is {vinodsalary}");
        }
    }
}
