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
            string pattern = @">>(?<furniture>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
            var names = new List<string>();
            double total = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Purchase")
                {
                    break;
                }
                var matchedFurniture = Regex.Matches(input, pattern);

                foreach (Match furniture in matchedFurniture)
                {

                    var name = furniture.Groups["furniture"].Value;
                    var price = double.Parse(furniture.Groups["price"].Value);
                    var quantity = int.Parse(furniture.Groups["quantity"].Value);
                    names.Add(name);
                    total += price * quantity;
                }


            }
            Console.WriteLine("Bought furniture:");
            if (names.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, names));
            }

            Console.WriteLine($"Total money spend: {total:F2}");




        }
    }
}