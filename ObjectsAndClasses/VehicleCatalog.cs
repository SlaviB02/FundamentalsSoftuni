using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp84
{
    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }


    }
    public class Car
    {
        public Car(string brand, string model, int hP)
        {
            Brand = brand;
            Model = model;
            HP = hP;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HP { get; set; }

    }
    public class CatalogVehicle
    {
        public CatalogVehicle()
        {
            Trucks =new List<Truck>();
            Cars = new List<Car>();
        }

        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            CatalogVehicle catalog = new CatalogVehicle();
            while(input!="end")
            {
                string[] info = input.Split("/");
                string vehicleType = info[0];
                string vehicleBrand = info[1];
                string vehicleModel = info[2];
                int value = int.Parse(info[3]);
                if (vehicleType == "Truck")
                {
                    Truck truck = new Truck(vehicleBrand,vehicleModel,value);
                    catalog.Trucks.Add(truck);
                }
                else
                {
                    Car car = new Car(vehicleBrand, vehicleModel, value);
                    catalog.Cars.Add(car);
                }
                input = Console.ReadLine();
            }
            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
            }
            foreach(var car in catalog.Cars.OrderBy(x =>x.Brand))
            {
                Console.WriteLine($"{ car.Brand}: { car.Model} - { car.HP}hp");
            }
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
            }
            foreach(var truck in catalog.Trucks.OrderBy(x =>x.Brand))
            {
                Console.WriteLine($"{ truck.Brand}: { truck.Model} - { truck.Weight}kg");
            }
        }
    }
}
