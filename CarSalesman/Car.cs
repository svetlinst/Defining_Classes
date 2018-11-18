using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
        }

        public Car(string model, Engine engine, int weight) : this(model, engine)
        {
            this.weight = weight;
        }

        public Car(string model, Engine engine, int weight, string color) : this(model, engine, weight)
        {
            this.color = color;
        }

        public Car(string model, Engine engine, string color) : this(model, engine)
        {
            this.color = color;
        }

        public Car(string model, Engine engine, string color, int weight) : this(model, engine, color)
        {
            this.weight = weight;
        }

        public override string ToString()
        {
            string clr;
            if (this.Color==null)
            {
                clr = "n/a";
            }
            else
            {
                clr = this.color;
            }

            string wgh;
            if (this.weight ==0)
            {
                wgh = "n/a";
            }
            else
            {
                wgh = this.weight.ToString();
            }

            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"{this.model}:");
            builder.AppendLine($"{this.engine}");
            builder.AppendLine($"  Weight: {wgh}");
            builder.Append($"  Color: {clr}");
            string result = builder.ToString();
            return result;
        }
    }
}
