using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemInterface.Entities
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
