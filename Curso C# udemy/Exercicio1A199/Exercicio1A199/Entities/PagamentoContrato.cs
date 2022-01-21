using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1A199.Entities
{
    class PagamentoContrato
    {
        private double BasicPayment { get; set; }

        public PagamentoContrato(double basicPayment)
        {
            BasicPayment = basicPayment;
        }

        private double TotalPayment
        {
            get { return BasicPayment; }
        }

        public override string ToString()
        {
            return "Value installments: " +
                TotalPayment.ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }
    }
}
