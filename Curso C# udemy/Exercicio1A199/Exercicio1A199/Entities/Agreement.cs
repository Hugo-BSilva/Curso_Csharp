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
        public Installments Installments { get; set; }


        public Agreement()
        {
        }

        public Agreement(int numberContract, DateTime dateOfContract, double totalPayment)
        {
            NumberContract = numberContract;
            DateOfContract = dateOfContract;
            TotalPayment = totalPayment;
        }

        public override string ToString()
        {
            return "Value installments: " +
                TotalPayment.ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }
    }
}
