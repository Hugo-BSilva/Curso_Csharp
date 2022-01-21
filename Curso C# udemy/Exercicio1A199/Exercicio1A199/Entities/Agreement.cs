using System;
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
        public double TotalContractValue { get; set; }

        public Agreement(int numberContract, DateTime dateOfContract, double totalContractValue)
        {
            NumberContract = numberContract;
            DateOfContract = dateOfContract;
            TotalContractValue = totalContractValue;
        }

        public Agreement(double totalContractValue)
        {
            TotalContractValue = totalContractValue;
        }

        public override string ToString()
        {
            return "Value installments: " +
                TotalContractValue.ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }

    }
}
