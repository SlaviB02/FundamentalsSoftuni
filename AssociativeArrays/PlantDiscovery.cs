using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> plants = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->");
                string name = input[0];
                double rarity = double.Parse(input[1]);
                if (plants.ContainsKey(name) == false)
                {
                    plants.Add(name, new List<double> { });
                    plants[name].Add(rarity);
                }
                else
                {
                    plants[name][0] = rarity;
                }
            }
            while (true)
            {
                string[] command = Console.ReadLine().Split(": ");
                if (command[0] == "Exhibition")
                {
                    break;
                }
                if (command[0] == "Rate")
                {
                    string[] token = command[1].Split(" - ");
                    string name = token[0];
                    double rarity = double.Parse(token[1]);
                    if (plants.ContainsKey(name))
                    {
                        plants[name].Add(rarity);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                if (command[0] == "Update")
                {
                    string[] token = command[1].Split(" - ");
                    string name = token[0];
                    double rarity = double.Parse(token[1]);
                    if (plants.ContainsKey(name))
                    {
                        plants[name][0] = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                if (command[0] == "Reset")
                {
                    string name = command[1];
                    if (plants.ContainsKey(name))
                    {
                        double rarity = plants[name][0];
                        plants[name].Clear();
                        plants[name].Add(rarity);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plants)
            {
                double average = 0;
                
                for (int i=1;i<plant.Value.Count;i++)
                {
                    average += plant.Value[i];
                }
                if (plant.Value.Count == 1)
                {
                    Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value[0]}; Rating: {0:F2}");
                }
                else
                {
                   
                    Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value[0]}; Rating: {average / (plant.Value.Count - 1):F2}");
                }
            }
        }
    }
}
