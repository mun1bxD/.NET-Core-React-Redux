using System;

namespace OOP_Inheritance_002
{
    public class Vehical
    {
        public string Brand;
        public string Model;
        public int Year; // Changed to uppercase to match other instances

        public Vehical(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public void Start()
        {
            Console.WriteLine("Starting the vehicle...");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the vehicle...");
        }
    }

    class Car : Vehical
    {
        public int NumberOfDoors;
        public string FuelType;

        public Car(int numberOfDoors, string fuelType, string brand, string model, int year) : base(brand, model, year)
        {
            NumberOfDoors = numberOfDoors;
            FuelType = fuelType;
        }

        public void Honk()
        {
            Console.WriteLine("Honking the car horn!");
        }
    }

    class ElectricCar : Car
    {
        public int BatteryCapacity;
        public int Range;

        public ElectricCar(string brand, string model, int year, int numberOfDoors, string fuelType, int batteryCapacity, int range)
            : base(numberOfDoors, fuelType, brand, model, year)
        {
            BatteryCapacity = batteryCapacity;
            Range = range;
        }

        public void Charge()
        {
            Console.WriteLine("Charging the electric car...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ElectricCar myTesla = new ElectricCar("Tesla", "Model S", 2022, 4, "Electric", 100, 370);

            Console.WriteLine($"Brand: {myTesla.Brand}");
            Console.WriteLine($"Model: {myTesla.Model}");
            Console.WriteLine($"Year: {myTesla.Year}");
            Console.WriteLine($"Doors: {myTesla.NumberOfDoors}");
            Console.WriteLine($"Fuel Type: {myTesla.FuelType}");
            Console.WriteLine($"Battery Capacity: {myTesla.BatteryCapacity} kWh");
            Console.WriteLine($"Range: {myTesla.Range} miles");

            myTesla.Start();
            myTesla.Honk();
            myTesla.Charge();
            myTesla.Stop();

            Console.WriteLine("Press any key to exit....");
            Console.ReadKey();
        }
      
    }
}
