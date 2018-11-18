using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace RawData
{
    public class Car
    {
        public string model { get; set; }
        public Engine engine { get; set; }
        public Cargo cargo { get; set; }
        public List<Tire> tires { get; set; }

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tires = tires;
        }
    }
}
