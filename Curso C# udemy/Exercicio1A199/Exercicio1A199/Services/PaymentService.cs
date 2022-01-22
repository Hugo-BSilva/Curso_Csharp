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
        public double TotalPayment { get; set; }

        private IPayment _payment;
       

        public PaymentService(int monthlyPayment, IPayment payment, double totalPayment)
        {
            MonthlyPayment = monthlyPayment;
            //Agreement = agreement;
            _payment = payment;
            TotalPayment = totalPayment;
        }

        /// <summary>
        /// Gerar as parcelas.
        /// </summary>
        public void GenerateInstallments(Agreement agreement)
        {            
            double agreementValue = TotalPayment / MonthlyPayment;

            var jurosSimples = _payment.PaymentRate(agreementValue) + agreementValue;

            var taxaPagamento = _payment.SimpleInterest(jurosSimples) + jurosSimples;

            double resultado = taxaPagamento;

            new Agreement(resultado);

            //return taxaPagamento + taxaPagamento;
        }
    }
}
