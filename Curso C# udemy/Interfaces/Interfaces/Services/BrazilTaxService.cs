using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    class BrazilTaxService
    {
        /// <summary>
        /// O imposto deve ser de 20% para valores abaixo de 100, acima disso 15%.
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public double Tax(double price)
        {
            if (price > 100)
            {
                return price * 0.15;
            }
            else
            {
                return price * 0.20;
            }
        }
    }
}
