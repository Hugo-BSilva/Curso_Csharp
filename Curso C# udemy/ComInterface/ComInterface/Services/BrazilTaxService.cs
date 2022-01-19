using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComInterface.Services
{
    class BrazilTaxService : ITaxService
    {
        /// <summary>
        /// O imposto deve ser de 20% para valores abaixo de 100, acima disso 15%.
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public double Tax(double amount)
        {
            if (amount > 100)
            {
                return amount * 0.15;
            }
            else
            {
                return amount * 0.20;
            }
        }
    }
}
