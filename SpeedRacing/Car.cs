using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private double distanceTravelled;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }
        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }
        public double DistanceTravelled
        {
            get { return this.distanceTravelled; }
            set { this.distanceTravelled = value; }
        }

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
            this.distanceTravelled = 0;
        }

        public bool TripPossible(double distance)
        {
            var isPossible = false;
            double requiredFuel = distance * this.fuelConsumption;
            if (requiredFuel<= this.fuelAmount)
            {
                this.fuelAmount -= requiredFuel;
                this.distanceTravelled += distance;
                isPossible = true;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }

            return isPossible;
        }
    }
}
