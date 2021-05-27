using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_26052021.Basics
{
    class AccountDetails
    {
        public int accountNumber;
        public string name;
        public int balance = 0;
        public int deposit;
        public int withdraw;

        public int totaldeposit(int accountNumber, string name,int deposit)
        {
            if (deposit >= 0)
            {
                deposit = deposit + balance;
            }
            return deposit;
        }
        public int totalbalance(int accountNumber, string name,int withdraw)
        {
            if (withdraw >=0)
            {
                balance = deposit - withdraw;
            }
            return balance;
        }

        static void Main(string[] args)
        {
            AccountDetails vinod = new AccountDetails();
            int dep = vinod.totaldeposit (1234, "vinod" , 10000);
            int bal = vinod.totalbalance (1234, "vinod", 5000);

            Console.WriteLine($"total deposit is {dep}");
            Console.WriteLine($"total bala is {bal}");
        }
    }
}
