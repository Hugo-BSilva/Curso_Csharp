using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    //Conta poupança
    //Sealed torna a classe selada, dessa forma não vai ser possível outra classe herdar ela
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; } //Taxa de juros

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate):base(number,holder,balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //Esse método não pode ser sobreposto novamente em outra classe
        public sealed override void Withdraw(double amount)
        {
            //Balance -= amount;
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
