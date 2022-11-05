using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp106
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(#|\|)(?<name>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calorie>\d{1,5})\1";
            string input = Console.ReadLine();
            MatchCollection food = Regex.Matches(input, pattern);
            int totalCalories = 0;
            foreach(Match item in food)
            {
                int calories = int.Parse(item.Groups["calorie"].Value);
                totalCalories += calories;
            }
            int days = 0;
            while(totalCalories>=2000)
            {
                totalCalories -= 2000;
                days++;
            }
            Console.WriteLine($"You have food to last you for: {days} days!");
            if (food.Count > 0)
            {
                foreach (Match item in food)
                {
                    string name = item.Groups["name"].Value;
                    string date = item.Groups["date"].Value;
                    string calories = item.Groups["calorie"].Value;
                    Console.WriteLine($"Item: {name}, Best before: {date}, Nutrition: {calories}");
                }
            }
        }
    }
}
