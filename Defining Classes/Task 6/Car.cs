using System;

namespace DefiningClasses
{
    public class Car
    {
        public Car()
        {
            this.TraveledDistance = 0;
        }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer) : this()
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }

        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double traveledDistance;

        public string Model
        {
            get => model;
            set => model = value;
        }

        public double FuelAmount
        {
            get => fuelAmount;
            set => fuelAmount = value;
        }

        public double FuelConsumptionPerKilometer
        {
            get => fuelConsumptionPerKilometer;
            set => fuelConsumptionPerKilometer = value;
        }

        public double TraveledDistance
        {
            get => traveledDistance;
            set => traveledDistance = value;
        }

        public void CalculateFuel(double amountOfKm)
        {
            if (this.fuelAmount < amountOfKm*this.fuelConsumptionPerKilometer)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.traveledDistance += amountOfKm;
                this.fuelAmount -= amountOfKm * this.fuelConsumptionPerKilometer;
            }
        }
    }
}