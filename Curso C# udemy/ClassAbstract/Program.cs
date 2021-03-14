using System;
using ClassAbstract.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace ClassAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> acc = new List<Account>();

            acc.Add(new SavingsAccount(1001, "Alex", 500, 0.01));
            acc.Add(new BusinessAccount(1003, "Maria", 500, 400));
            acc.Add(new SavingsAccount(1004, "Rob", 500, 0.01));
            acc.Add(new BusinessAccount(1005, "Pria", 500, 400));

            double sum = 0;

            foreach (Account item in acc)
            {
                sum += item.Balance;
            }

            Console.WriteLine("Total Balance: "+ sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account item in acc)
            {
                item.Withdraw(10.0);
            }

            foreach (Account item in acc)
            {
                Console.WriteLine("Update balance for account " + 
                    item.Number + " : " +
                    item.Balance);
            }
        }
    }
}
