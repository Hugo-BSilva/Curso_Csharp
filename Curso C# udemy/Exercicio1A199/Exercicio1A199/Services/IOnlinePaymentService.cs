using Exercicio1A199.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1A199.Services
{
    interface IOnlinePaymentService
    {
        double SimpleInterest(double amount, int months);
        double PaymentRate(double amount);
    }
}
