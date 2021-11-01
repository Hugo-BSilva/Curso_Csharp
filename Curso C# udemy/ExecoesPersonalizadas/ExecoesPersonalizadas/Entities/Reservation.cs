using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecoesPersonalizadas.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime ChekcOut { get; set; }

        public Reservation() { }
        public Reservation(int roomNumber, DateTime checkIn, DateTime chekcOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            ChekcOut = chekcOut;
        }

        public int Duration()
        {
            //A diferança entre um instante e outro
            TimeSpan duration = ChekcOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            ChekcOut = checkOut;
        }

        public override string ToString()
        {
            return "Room " + RoomNumber +
                ", CheckIn: " + CheckIn.ToString("dd/MM/yyyy") +
                ", CheckOut: " + ChekcOut.ToString("dd/MM/yyyy") +
                ", Duration: " + Duration() + " nights.";
        }
    }
}
