using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            Queue<Car> cars = new Queue<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                List<Tire> tires = new List<Tire>();

                Tire tireOne = new Tire(double.Parse(input[5]), int.Parse(input[6]));
                Tire tireTwo = new Tire(double.Parse(input[7]), int.Parse(input[8]));
                Tire tireThree = new Tire(double.Parse(input[9]), int.Parse(input[10]));
                Tire tireFour = new Tire(double.Parse(input[11]), int.Parse(input[12]));
                
                tires.Add(tireOne);
                tires.Add(tireTwo);
                tires.Add(tireThree);
                tires.Add(tireFour);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Car newCar = new Car(model, engine, cargo, tires);
                
                cars.Enqueue(newCar);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.Type == "fragile" && car.Tires.Any(n => n.Pressure < 1))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.Type == "flamable" && car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
   
}
