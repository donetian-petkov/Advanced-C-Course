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

            HashSet<Car> carsSet = new HashSet<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionPerKilometer = double.Parse(input[2]);

                Car newCar = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                
                carsSet.Add(newCar);
            }

            List<Car> cars = carsSet.ToList();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (input[0] == "End")
                {
                    break;
                }

                string model = input[1];
                double amountOfKm = double.Parse(input[2]);

                Car newCar = cars.Find(n => n.Model == model);
                
                newCar.CalculateFuel(amountOfKm);

            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }
   
}
