using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp101
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern =@"^%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<item>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            double total = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift")
                {
                    Console.WriteLine($"Total income: {total:F2}");
                    break;
                }
                var matched = Regex.Matches(input, pattern);

                foreach (Match match in matched)
                {

                    var name = match.Groups["name"].Value;
                    var price = double.Parse(match.Groups["price"].Value);
                    var count = int.Parse(match.Groups["count"].Value);
                    var item = match.Groups["item"].Value;
                    double totalPrice = price * count;
                    Console.WriteLine($"{name}: {item} - {totalPrice:F2}");
                    total += totalPrice;
                }
                

            }
            




        }
    }
}