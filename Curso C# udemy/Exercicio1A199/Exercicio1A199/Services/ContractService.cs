using Exercicio1A199.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1A199.Services
{
    class ContractService
    {
        //public Agreement Agreement { get; set; }
        //public int Months { get; set; }

        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            //Agreement = agreement;
            //Months = months;
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Agreement agreement, int months)
        {
            double agreementValue = agreement.TotalPayment / months;

            var jurosSimples = _onlinePaymentService.PaymentRate(agreementValue) + agreementValue;

            var taxaPagamento = _onlinePaymentService.SimpleInterest(jurosSimples, months) + jurosSimples;

            double resultado = taxaPagamento;

            new Installments(resultado);
        }
    }
}
