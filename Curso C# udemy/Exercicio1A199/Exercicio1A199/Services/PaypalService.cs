using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1A199.Services
{
    /// <summary>
    /// Serviço de pagamento pelo Paypal.
    /// </summary>
    class PaypalService : IOnlinePaymentService
    {
        public double PaymentRate(double amount)
        {
            return amount * 0.02;
        }

        public double SimpleInterest(double amount, int months)
        {
            return amount * 0.01 * months;
        }
    }
}
