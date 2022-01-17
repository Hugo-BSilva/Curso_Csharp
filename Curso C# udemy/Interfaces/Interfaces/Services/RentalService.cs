using Interfaces.Entities;
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
        public double PriceHour { get; private set; }
        public double PriceDay { get; private set; }

        //Dependência de forma errada
        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double priceHour, double priceDay)
        {
            PriceHour = priceHour;
            PriceDay = priceDay;
        }

        /// <summary>
        /// Processar nota de pagamento.
        /// </summary>
        /// <param name="carRental"></param>
        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            if (duration.TotalHours <= 12.0)
            {
                //Math.Ceiling método para arredondar as horas para cima
                basicPayment = PriceHour * Math.Ceiling(duration.TotalHours);
            }
        }
    }
}
