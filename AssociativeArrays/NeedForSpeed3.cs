using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();
            for (int i = 0; i < n; i++)
            {
                string[] car = Console.ReadLine().Split("|");
                string name = car[0];
                int miles = int.Parse(car[1]);
                int fuel = int.Parse(car[2]);
                cars.Add(name, new List<int> { miles, fuel });
            }
            
            while (true)
            {
                string[] command = Console.ReadLine().Split(" : ");
                if (command[0] == "Stop")
                {
                    break;
                }
                if(command[0]=="Drive")
                {
                    string car = command[1];
                    int distance = int.Parse(command[2]);
                    int fuel = int.Parse(command[3]);
                    if(cars[car][1]<fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        cars[car][0] += distance;
                        cars[car][1] -= fuel;
                    }
                    if(cars[car][0]>=100000)
                    {
                        Console.WriteLine($"Time to sell the {car}!");
                        cars.Remove(car);
                    }
                }
                if(command[0]=="Refuel")
                {
                    string car = command[1];
                    int fuel = int.Parse(command[2]);
                    if(cars[car][1]+fuel>75)
                    {
                        int usedFuel = 75 - cars[car][1];
                        cars[car][1] = 75;
                        Console.WriteLine($"{car} refueled with {usedFuel} liters");
                    }
                    else
                    {
                        cars[car][1] += fuel;
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                }
                if(command[0]=="Revert")
                {
                    string car = command[1];
                    int km = int.Parse(command[2]);
                    if (cars[car][0] -km <10000)
                    {
                        cars[car][0] =10000;
                    }
                    else
                    {
                        cars[car][0] -=km;
                        Console.WriteLine($"{car} mileage decreased by {km} kilometers");
                    }
                }
                
            }
            foreach(var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
           
        }
    }
}
