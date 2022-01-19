using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1A199.Services
{
    interface IPayment
    {
        double SimpleInterest(double amount);
        double PaymentRate(double amount);
    }
}
