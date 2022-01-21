﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1A199.Entities
{
    class Agreement
    {
        public int NumberContract { get; set; }
        public DateTime DateOfContract { get; set; }
        public double TotalPayment { get; set; }
        //public int MonthlyPayment { get; set; }

        public Agreement(double totalPayment)
        {
            TotalPayment = totalPayment;
            //NumberContract = numberContract;
            //DateOfContract = dateOfContract;
        }

        public override string ToString()
        {
            return "Value installments: " +
                TotalPayment.ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }
    }
}
