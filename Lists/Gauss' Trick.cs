using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            int originalCount = numbers.Count;
            for(int i=0;i<originalCount/2;i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }
            foreach(double num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
