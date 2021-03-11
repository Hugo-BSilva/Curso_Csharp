namespace Heranca.Entities
{
    //Conta para empresas vai ter tudo que a Account tem
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        //Construtores
        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }


        //Método de empréstimo
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
