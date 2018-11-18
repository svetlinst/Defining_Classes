using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int engineEntries = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < engineEntries; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                var model = input[0];
                var power = int.Parse(input[1]);
                int displacement;
                string efficiency;
                if (input.Length==3)
                {
                    try
                    {
                        displacement = int.Parse(input[2]);
                        Engine currEngine = new Engine(model, power, displacement);
                        engines.Add(currEngine);

                    }
                    catch (Exception e)
                    {
                        efficiency = input[2];
                        Engine currEngine = new Engine(model, power, efficiency);
                        engines.Add(currEngine);

                    }
                }
                else if (input.Length == 4)
                {
                    try
                    {
                        displacement = int.Parse(input[2]);
                        efficiency = input[3];
                        Engine currEngine = new Engine(model, power, displacement, efficiency);
                        engines.Add(currEngine);


                    }
                    catch (Exception e)
                    {
                        efficiency = input[2];
                        displacement = int.Parse(input[3]);
                        Engine currEngine = new Engine(model, power, efficiency, displacement);
                        engines.Add(currEngine);

                    }
                }
                else
                {
                    Engine currEngine = new Engine(model, power);
                    engines.Add(currEngine);
                }
                
            }

            var carEntries = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < carEntries; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                var model = input[0];
                var engineModel = input[1];
                Engine carsEngine = engines.FirstOrDefault(x => x.Model == engineModel);
                Car currCar = new Car(model, carsEngine);
                int weight;
                string color;
                if (input.Length ==3)
                {
                    if (int.TryParse(input[2], out weight))
                    {
                        currCar.Weight = weight;
                    }
                    else
                    {
                        color = input[2];
                        currCar.Color = color;
                    }
                }else if (input.Length==4)
                {
                    weight = int.Parse(input[2]);
                    color = input[3];
                    currCar.Weight = weight;
                    currCar.Color = color;
                }
                cars.Add(currCar);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
