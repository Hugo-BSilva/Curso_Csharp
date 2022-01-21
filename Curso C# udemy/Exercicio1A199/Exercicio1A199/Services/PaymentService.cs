using Exercicio1A199.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1A199.Services
{
    class PaymentService
    {
        public int MonthlyPayment { get; set; }
        public Agreement Agreement { get; set; }

        private IPayment _payment;
       

        public PaymentService(int monthlyPayment, Agreement agreement, IPayment payment)
        {
            MonthlyPayment = monthlyPayment;
            Agreement = agreement;
            _payment = payment;
        }

        /// <summary>
        /// Gerar as parcelas.
        /// </summary>
        public void GenerateInstallments(Agreement agreement)
        {
            double agreementValue = Agreement.TotalContractValue / MonthlyPayment;

            var jurosSimples = _payment.PaymentRate(agreementValue);

            var taxaPagamento = _payment.SimpleInterest(jurosSimples);

            agreement = new Agreement(taxaPagamento);
        }
    }
}
