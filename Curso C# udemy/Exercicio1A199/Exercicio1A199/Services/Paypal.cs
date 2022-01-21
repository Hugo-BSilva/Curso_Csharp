using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1A199.Services
{
    class Paypal : IPayment
    {
        public double PaymentRate(double amount)
        {
            return amount * 0.01;
        }

        public double SimpleInterest(double amount)
        {
            return amount + 0.02;
        }
    }
}
