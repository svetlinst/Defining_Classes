using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            for (int i = 0; i < entries; i++)
            {
                var tokens = Console.ReadLine().Split().ToArray();
                var model = tokens[0];
                double fuelAmount = double.Parse(tokens[1]);
                double fuelConsumption = double.Parse(tokens[2]);
                Car currentCar = new Car(model, fuelAmount,fuelConsumption);
                if (!cars.ContainsKey(model))
                {
                    cars.Add(model, currentCar);
                }
            }

            var input = Console.ReadLine().Split().ToArray();
            while (input[0]!="End")
            {
                var curModel = input[1];
                var distance = double.Parse(input[2]);
                Car currentCar = cars[curModel];
                currentCar.TripPossible(distance);
                input = Console.ReadLine().Split().ToArray();
            }

            foreach (var car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTravelled}");
            }
        }
    }
}
