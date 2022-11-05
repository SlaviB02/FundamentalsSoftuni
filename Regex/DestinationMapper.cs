using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp105
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(=|/)(?<name>[A-Z][A-z]{2,})\1";
            string input = Console.ReadLine();
            List<string> cities = new List<string>();
            MatchCollection destinations = Regex.Matches(input, pattern);
            int points = 0;
            foreach(Match city in destinations)
            {
                string word = city.Groups["name"].Value;
                cities.Add(word);
                points += word.Length;
            }
            Console.Write($"Destinations: ");
            Console.WriteLine(string.Join(", ", cities));
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
