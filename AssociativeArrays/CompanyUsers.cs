using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp98
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            while(true)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                if(input[0]=="End")
                {
                    break;
                }
                string companyName = input[0];
                string id = input[1];
                if(!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }
                if (!companies[companyName].Contains(id))
                {
                    companies[companyName].Add(id);
                }
            }
          foreach(var company in companies)
            {
                Console.WriteLine(company.Key);
                foreach(var people in company.Value)
                {
                    Console.WriteLine($"-- {people}");
                }

            }
        }
    }
}
