using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public int Displacement
        {
            get { return this.displacement; }
            set { this.displacement = value; }
        }

        public string Efficiency
        {
            get { return this.efficiency; }
            set { this.efficiency = value; }
        }
        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
        }

        public Engine(string model, int power, int displacement) : this(model, power)
        {
            this.displacement = displacement;
        }

        public Engine(string model, int power, int displacement, string efficiency) : this(model, power, displacement)
        {
            this.efficiency = efficiency;
        }

        public Engine(string model, int power, string efficiency) : this(model, power)
        {
            this.efficiency = efficiency;
        }

        public Engine(string model, int power, string efficiency, int displacement) : this(model, power, efficiency)
        {
            this.displacement = displacement;
        }

        public override string ToString()
        {
            string eff;
            if (this.efficiency==null)
            {
                eff = "n/a";
            }
            else
            {
                eff = this.efficiency;
            }

            string disp;
            if (this.displacement == 0)
            {
                disp = "n/a";
            }
            else
            {
                disp = displacement.ToString();
            }
            StringBuilder str = new StringBuilder();
            str.AppendLine($"  {this.model}:");
            str.AppendLine($"    Power: {this.power}");
            str.AppendLine($"    Displacement: {disp}");
            str.Append($"    Efficiency: {eff}");
            string result = str.ToString();
            return result;
        }
    }
}
