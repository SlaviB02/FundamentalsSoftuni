using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp61
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> greaterThanAverage = new List<int>();
            double average = 0.0;
            for(int i=0;i<numbers.Count;i++)
            {
                average += numbers[i];
            }
            average = average / numbers.Count;
            numbers.Reverse();
            bool flag = true;
            for(int i=0;i<numbers.Count;i++)
            {
                if(numbers[i]>average )
                {
                    flag = false;
                    greaterThanAverage.Add(numbers[i]);
                }
            }
            if(flag==true)
            {
                Console.WriteLine("No");
                return;
            }
            greaterThanAverage.Sort();
            greaterThanAverage.Reverse();
            if (greaterThanAverage.Count > 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(greaterThanAverage[i] + " ");
                }
            }
            else
            {
                for (int i = 0; i < greaterThanAverage.Count; i++)
                {
                    Console.Write(greaterThanAverage[i] + " ");
                }
            }
      
        }
    }
}
