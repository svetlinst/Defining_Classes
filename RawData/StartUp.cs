using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < entries; i++)
            {
                var tokens = Console.ReadLine().Split().ToArray();
                var model = tokens[0];
                var engineSpeed = int.Parse(tokens[1]);
                var enginePower = int.Parse(tokens[2]);
                Engine currEngine = new Engine(engineSpeed, enginePower);
                var cargoWeight = int.Parse(tokens[3]);
                var cargoType = tokens[4];
                Cargo currCargo = new Cargo(cargoWeight, cargoType);
                List<Tire> tires = new List<Tire>();
                for (int j = 5; j < tokens.Length; j+=2)
                {
                    var pressure = double.Parse(tokens[j]);
                    var age = int.Parse(tokens[j + 1]);
                    tires.Add(new Tire(age, pressure));
                }
                Car currCar = new Car(model, currEngine,currCargo, tires);
                cars.Add(currCar);
            }

            var command = Console.ReadLine();
            if (command== "fragile")
            {
                var targetCars = cars.Where(x => x.cargo.cargoType == "fragile" && x.tires.Any(s => s.pressure < 1))
                    .ToList();
                foreach (var targetCar in targetCars)
                {
                    Console.WriteLine($"{targetCar.model}");
                }
            }
            else
            {
                var targetCars = cars.Where(x => x.cargo.cargoType == "flamable" && x.engine.enginePower > 250)
                    .ToList();
                foreach (var targetCar in targetCars)
                {
                    Console.WriteLine($"{targetCar.model}");
                }
            }
        }
    }
}
