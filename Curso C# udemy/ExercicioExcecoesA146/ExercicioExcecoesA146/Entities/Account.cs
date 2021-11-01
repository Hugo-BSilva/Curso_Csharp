using ExercicioExcecoesA146.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioExcecoesA146.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {
        }
        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new DomainException("You tried entered amount null.");
            }
            else if (amount.GetType() != typeof(int) || amount.GetType() != typeof(double))
            {
                throw new DomainException("You no entered numbers.");
            }
            else
            {
                Balance += amount;
            }            
        }

        public void WithDraw(double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new DomainException("The amount entered for withdrawal is greater than the limit, please enter a smaller amount.");
            }
            else if(amount > Balance)
            {
                throw new DomainException("You have no this balance on your account. Your balance is: " + Balance);
            }
            else
            {
                Balance -= amount;
            }            
        }
    }
}
