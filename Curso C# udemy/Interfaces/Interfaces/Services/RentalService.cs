using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    /// <summary>
    /// Serviço de aluguel
    /// </summary>
    class RentalService
    {
        public double PriceHour { get; set; }
        public double PriceDay { get; set; }

        /// <summary>
        /// Processar nota de pagamento
        /// </summary>
        /// <param name="carRental"></param>
        public void ProcessInvoice(CarRental carRental)
        {

        }

        public double BasicPayment(DateTime pickup, DateTime regress)
        {
            //int dateReturn = TimeSpan.
            if (pickup.Hour > regress.Hour)
            {

            }

            return 0;
        }

        

        public double TotalPayment()
        {

            return 0;
        }
    }
}
