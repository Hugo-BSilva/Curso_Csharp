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
        public double MonthlyPayment { get; set; }
        public Agreement Agreement { get; set; }

        private IPayment _payment;
       

        public PaymentService(double monthlyPayment, Agreement agreement)
        {
            MonthlyPayment = monthlyPayment;
            Agreement = agreement;
        }

        /// <summary>
        /// Gerar as parcelas.
        /// </summary>
        public void GenerateInstallments(int numberOfMonths)
        {
            double agreementValue = Agreement.TotalContractValue / numberOfMonths;

            var jurosSimples = _payment.PaymentRate(agreementValue);

            var taxaPagamento = _payment.SimpleInterest(jurosSimples);

            Agreement = new Agreement(taxaPagamento);
        }
    }
}
