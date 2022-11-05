using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp104
{
    class Program
    {
        static void Main(string[] args)
        {
            string emojiPattern = @"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string digitPattern = @"\d";
            string input = Console.ReadLine();
            List<string> coolEmoji = new List<string>();
            var matchedEmoji = Regex.Matches(input, emojiPattern);
            var matchedDigits = Regex.Matches(input, digitPattern);
           int cool = 1;
            foreach(Match digit in matchedDigits)
            {
                int number =int.Parse(digit.Value);
                cool *= number;
            }
            Console.WriteLine($"Cool threshold: {cool}");
            if (matchedEmoji.Count > 0)
            {
                Console.WriteLine($"{matchedEmoji.Count} emojis found in the text. The cool ones are:");
                foreach (Match match in matchedEmoji)
                {
                    int sum = 0;
                    string emoji = match.Groups["emoji"].Value;

                    for (int i = 0; i < emoji.Length; i++)
                    {
                        sum += emoji[i];
                    }
                    if (sum > cool)
                    {
                        string wholeEmoji = match.Value;
                        coolEmoji.Add(wholeEmoji);
                    }
                }
                Console.WriteLine(string.Join(Environment.NewLine, coolEmoji));
            }
          
        }
    }
}
