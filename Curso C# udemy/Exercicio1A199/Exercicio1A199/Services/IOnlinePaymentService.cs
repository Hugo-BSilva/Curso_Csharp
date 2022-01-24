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

        /// <summary>
        /// Gerar as parcelas.
        /// </summary>
        //public void GenerateInstallments()
        //{            
        //    double agreementValue = Agreement.TotalPayment / MonthlyPayment;

        //    var jurosSimples = _payment.PaymentRate(agreementValue) + agreementValue;

        //    var taxaPagamento = _payment.SimpleInterest(jurosSimples) + jurosSimples;

        //    double resultado = taxaPagamento;

        //    new Installments(resultado);
        //}
    }
}
