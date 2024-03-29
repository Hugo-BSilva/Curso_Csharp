﻿using System;
using System.Globalization;
using System.Collections.Generic;

namespace Composição.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; } //Valor por hora
        public int Hours { get; set; }

        public HourContract()
        {
        }
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }


        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
