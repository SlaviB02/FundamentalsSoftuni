using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp94
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> result = new Dictionary<string, List<decimal>>();

           while(true)
            {
                string[] input = Console.ReadLine().Split();
                if(input[0]=="buy")
                {
                    break;
                }
                string name = input[0];
                decimal price = decimal.Parse(input[1]);
                decimal quantity = decimal.Parse(input[2]);
                if (!result.ContainsKey(name))
                {
                    result.Add(name, new List<decimal>(){ price,quantity});
                }
                else
                {
                    result[name][0] = price;
                    result[name][1] += quantity;
                }
            }
           foreach(var product in result)
            {
                Console.WriteLine($"{product.Key} -> {product.Value[0]*product.Value[1]:F2}");
            }
        }
    }
}
