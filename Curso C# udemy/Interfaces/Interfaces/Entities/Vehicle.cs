﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entities
{
    class Vehicle
    {
        private string Model { get; set; }

        public Vehicle(string model)
        {
            Model = model;
        }
    }
}
