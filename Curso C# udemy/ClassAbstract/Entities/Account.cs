﻿using System;

namespace ClassAbstract.Entities
{
    abstract class Account //Conta
    {
        //private set (eu só posso acessar eu não posso alterar)
        //protected só pode ser alterado na própria classe ou na subclasse
        public int Number { get; private set; } //Número da conta
        public string Holder { get; private set; } //Titular da conta
        public double Balance { get; protected set; } // Saldo

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        /* Método para saque, ela possui o prefixo virtual justamente para que a SavingAccount possa 
        sobrescrever esse método */
        public virtual void Withdraw(double amount) //recebe uma quantia como parâmetro de entrada
        {
            Balance -= amount + 5;
        }

        //Método para depósito
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
