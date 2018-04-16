using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount s1 = new SavingsAccount(50);
            SavingsAccount s2 = new SavingsAccount(100);
            Console.WriteLine(SavingsAccount.GetInterestRate());
            SavingsAccount.SetInterestRate(0.08);
            SavingsAccount s3 = new SavingsAccount(1000.75);
            Console.WriteLine(SavingsAccount.GetInterestRate());


        }
    }
    class SavingsAccount
    {
        public double currentBalance;
        public static double currentInterestRate;
        public SavingsAccount(double balance)
        {
            currentBalance = balance;
        }
        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currentInterestRate = 0.04;
        }
        public static double GetInterestRate()
        {
            return currentInterestRate;
        }
        public static void SetInterestRate(double newRate)
        {
            currentInterestRate = newRate;
        } 
    }
}
