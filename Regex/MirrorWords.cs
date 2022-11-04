using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ConsoleApp103
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(@|#)(?<first>[A-z]{3,})\1{2}(?<second>[A-z]{3,})\1";
            string input = Console.ReadLine();
            Dictionary<string,string> validWords = new Dictionary<string, string>();
            MatchCollection words = Regex.Matches(input, pattern);
            if(words.Count>0)
            {
                Console.WriteLine($"{words.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }
            int count = 0;
            foreach(Match word in words)
            {
                string firstWord = word.Groups["first"].Value;
                string secondWord = word.Groups["second"].Value;
                string reverse = "";
                for(int i=secondWord.Length-1;i>=0;i--)
                {
                    reverse += secondWord[i];
                }
                if (reverse == firstWord)
                {
                    count++;
                    validWords.Add(firstWord,secondWord);
                }
            }
            List<string> final = new List<string>();
            if (count!=0)
            {
                Console.WriteLine("The mirror words are:");
                string result = "";
                foreach (var word in validWords)
                {
                   
                    result = $"{word.Key} <=> {word.Value}";
                    final.Add(result);
                }
                Console.WriteLine(string.Join(", ", final));

            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
