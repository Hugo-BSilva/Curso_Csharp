using Exercicio1A199.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1A199.Services
{
    /// <summary>
    /// Serviço de contratos
    /// </summary>
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Agreement agreement, int months)
        {
            double valueInstallment = agreement.TotalPayment / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = agreement.DateOfContract.AddMonths(i);
                double simpleInterest = _onlinePaymentService.SimpleInterest(valueInstallment, i) + valueInstallment;
                double paymentRate = _onlinePaymentService.PaymentRate(simpleInterest) + simpleInterest;

                agreement.AddInstallments(new Installments(date, paymentRate));
            }      
        }
    }
}
