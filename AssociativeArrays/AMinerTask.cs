using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp93
{
    class Program
    {
        static void Main(string[] args)
        {  
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string resource="";
            int quantity = 0;
           while(true)
            {
                    resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }

                quantity = int.Parse(Console.ReadLine());
                
                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, 0);

                }
                resources[resource] += quantity;
               
            }
           foreach(var res in resources)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
