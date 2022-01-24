using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1A199.Entities
{
    class Installments
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installments( //DateTime dueDate,
            double amount)
        {
            //DueDate = dueDate;
            Amount = amount;
        }

        public Installments()
        {
        }

        public override string ToString()
        {
            return "Value installments: " +
                Amount.ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }
    }
}
