using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {
        public int cargoWeight { get; set; }
        public string cargoType { get; set; }

        public Cargo(int weight, string type)
        {
            this.cargoType = type;
            this.cargoWeight = weight;
        }

    }
}
