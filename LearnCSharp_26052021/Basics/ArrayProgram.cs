using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_26052021.Basics
{
    class ArrayProgram
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 };
            int count = 0;
            int count1 = 0; ;

            for (int i=0;i<=9;i++)
            {
                
                if (arr[i]==0)
                {
                    
                    count++;
                    //
                }
                else
                {
                    
                    count1++;
                   // 
                }
                
            }
            Console.WriteLine(count);
            Console.WriteLine(count1);
        }
    }
}
