using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> towns = new Dictionary<string, List<int>>();
            
            while(true)
            {
                string[] town = Console.ReadLine().Split("||");
                if(town[0]=="Sail")
                {
                    break;
                }
                string name = town[0];
                int citizen = int.Parse(town[1]);
                int gold = int.Parse(town[2]);
                if(towns.ContainsKey(name)==false)
                {
                    towns.Add(name,new List<int>{citizen,gold});
                }
                else
                {
                    towns[name][0] += citizen;
                    towns[name][1] += gold;
                }
            }
            while(true)
            {
                string[] command = Console.ReadLine().Split("=>");
                if(command[0]=="End")
                {
                    break;
                }
                if(command[0]=="Plunder")
                {
                    string town = command[1];
                    int people = int.Parse(command[2]);
                    int gold = int.Parse(command[3]);
                    towns[town][0] -= people;
                    towns[town][1] -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    if(towns[town][0]==0 ||towns[town][1]==0 )
                    {
                        towns.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                if(command[0]=="Prosper")
                {
                    string town = command[1];
                    int gold = int.Parse(command[2]);
                    if(gold<0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    towns[town][1] += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {towns[town][1]} gold.");
                }
            }
            if(towns.Count>0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
                foreach (var town in towns)
                {
                   
                    Console.WriteLine($"{town.Key} -> Population: {town.Value[0]} citizens, Gold: {town.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
