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
        public double TotalPayment { get; set; }
        public int MonthlyPayment { get; set; }
        public Agreement Agreement { get; set; }

        private IPayment _payment;
       

        public PaymentService(double totalPayment, int monthlyPayment, IPayment payment)
        {
            TotalPayment = totalPayment;
            MonthlyPayment = monthlyPayment;
            //Agreement = agreement;
            _payment = payment;
        }

        /// <summary>
        /// Gerar as parcelas.
        /// </summary>
        public double GenerateInstallments()
        {            
            double agreementValue = TotalPayment / MonthlyPayment;

            var jurosSimples = _payment.PaymentRate(agreementValue) + agreementValue;

            var taxaPagamento = _payment.SimpleInterest(jurosSimples) + jurosSimples;

            return taxaPagamento + taxaPagamento;
        }
    }
}
