using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        public double currentBalance;
        private static double currentInterestRate;

        static SavingsAccount()
        {
            Console.WriteLine("In static constructor");
            currentInterestRate = 0.04;
        }
        public SavingsAccount(double balance)
        {
            currentBalance = balance;
        }
        public static void SetInterestRate(double rate)
        {
            currentInterestRate = rate;
        }
        public static double GetInterestRate()
        {
            return currentInterestRate;
        }
    }
}
