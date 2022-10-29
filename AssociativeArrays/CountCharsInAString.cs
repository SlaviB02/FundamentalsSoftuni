using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp92
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string trimmed = String.Concat(input.Where(c => !Char.IsWhiteSpace(c)));
            Dictionary<char, int> letters = new Dictionary<char, int>();
            for(int i=0;i<trimmed.Length;i++)
            {
                if(letters.ContainsKey(trimmed[i])==true)
                {
                    letters[trimmed[i]]++;
                }
                else
                {
                    letters.Add(trimmed[i], 1);
                }
            }
            foreach(var let in letters)
            {
                Console.WriteLine($"{let.Key} -> {let.Value}");
            }
        }
    }
}
