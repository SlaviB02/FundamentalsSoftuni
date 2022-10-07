using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp60
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("|").ToList();
            input.Reverse();
            List<int> numbers = new List<int>();
            for(int i=0;i<input.Count;i++)
            {
                numbers.AddRange(input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList()
                         );
            }
            foreach(int num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
