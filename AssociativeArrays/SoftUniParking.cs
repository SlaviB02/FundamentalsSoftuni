using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp95
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();
            int number = int.Parse(Console.ReadLine());
            for(int i=0;i<number;i++)
            {
                string[] input = Console.ReadLine().Split();
                
                if(input[0]=="register")
                {
                    string userName = input[1];
                    string plate = input[2];
                    if (parking.ContainsKey(userName))
                    {
                        foreach(var user in parking)
                        {
                            if (user.Key == userName)
                            {
                                Console.WriteLine($"ERROR: already registered with plate number {user.Value}");
                            }
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine($"{userName} registered {plate} successfully");
                        parking.Add(userName, plate);
                    }
                }
                if(input[0]=="unregister")
                {
                    string userName = input[1];
                    if (!parking.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                        parking.Remove(userName);
                    }
                }
            }
            foreach(var user in parking)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
