using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp99
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternNames = @"[A-Za-z]";
            Dictionary<string, int> places = new Dictionary<string, int>();
            string [] names =Console.ReadLine().Split(", ").ToArray();
            foreach(var person in names)
            {
                if(!places.ContainsKey(person))
                {
                    places[person] = 0;
                }
            }
            while(true)
            {
                string input = Console.ReadLine();
                string name = "";
                int km = 0;
                if(input=="end of race")
                {
                    break;
                }
                var matchedNames = Regex.Matches(input,patternNames);

                foreach (Match match in matchedNames)
                {

                    name += match.Value;
                
                }
               
                if (places.ContainsKey(name))
                {
                    string patternDistance = @"[0-9]";
                    var distance = Regex.Matches(input, patternDistance);
                    foreach (Match dist in distance)
                    {
                        km += int.Parse(dist.Value);
                    }
                    places[name] += km;
                }

            }
            places = places.OrderByDescending(x => x.Value).ToDictionary(x => x.Key,x => x.Value);
            Console.WriteLine($"1st place: {places.Keys.ElementAt(0)}");
            Console.WriteLine($"2nd place: {places.Keys.ElementAt(1)}");
            Console.WriteLine($"3rd place: {places.Keys.ElementAt(2)}");




        }
    }
}
