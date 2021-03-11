using System;
using System.Collections.Generic;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
            //Console.WriteLine(account.Balance);

            //Account acc = new Account(1001, "alex", 0.0);
            //BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            ////UPCASTING
            ////Conversão do objeto bacc para um objeto acc1 do tipo Account é possível pois o Business Account é um Account
            //Account acc1 = bacc;
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            //Account acc3 = new SavingsAccount(1000, "Ana", 0.0, 0.01);

            ////DOWNCASTING
            ////É uma operação insegura, deve ser feita somente se muito necessário
            ////Converte a variável acc2 que é do tipo Account, para BusinessAccount
            //BusinessAccount acc4 = (BusinessAccount)acc2;
            //acc4.Loan(100.0);
            ////acc2.Loan(10); Apesar da variável acc2 ter instanciando BA ela não pode acessar os atributos e métodos da BA


            ////BusinessAccount acc5 = (BusinessAccount)acc3;
            ////Se a variável acc3 foi uma instância de BusinessAccount
            //if (acc3 is BusinessAccount)
            //{
            //    BusinessAccount acc5 = (BusinessAccount)acc3;
            //    //BusinessAccount acc5 = acc3 as BusinessAcount;
            //    acc5.Loan(200.0);
            //    Console.WriteLine("Loan");
            //}

            //if (acc3 is SavingsAccount)
            //{
            //    //SavingsAccount acc5 = (SavingsAccount)acc3;
            //    SavingsAccount acc5 = acc3 as SavingsAccount;
            //    acc5.UpdateBalance();
            //    Console.WriteLine("UPDATE");
            //}

            Account acc1 = new Account(1001, "Alex", 500);
            Account acc2 = new SavingsAccount(1002, "Anna", 500, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}
