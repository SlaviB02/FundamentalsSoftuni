using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> result = new List<string>();
            for(int i=0;i<number;i++)
            {
                string input = Console.ReadLine();
                result.Add(input);
            }
            result.Sort();
            for(int i=0;i<result.Count;i++)
            {
                Console.WriteLine($"{i+1}.{result[i]}");
            }
        }
    }
}
