using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComInterface.Entities
{
    /// <summary>
    /// Nota de pagamento.
    /// </summary>
    class Invoice
    {        
        private double BasicPayment { get; set; }
        private double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        private double TotalPayment { 
            get { return BasicPayment + Tax; } 
        }

        public override string ToString()
        {            
            return "Basic payment: " + 
                BasicPayment.ToString("F2", CultureInfo.InvariantCulture) + "\n" +
                "Tax: " + 
                Tax.ToString("F2", CultureInfo.InvariantCulture) + "\n" +
                "Total payment: " + 
                TotalPayment.ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }
    }
}
