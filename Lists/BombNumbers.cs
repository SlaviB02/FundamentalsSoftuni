using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp58
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bomb = bombAndPower[0];
            int power = bombAndPower[1];
            for(int i=0;i<numbers.Count;i++)
            {
                
                if(numbers[i]==bomb)
                {
                    numbers[i] = 0;
                    for(int j=1;j<=power;j++)
                    {
                        if(i-j>=0)
                        {
                            numbers[i - j] = 0;
                        }
                        if(i+j<=numbers.Count-1)
                        {
                            numbers[i + j] = 0;
                        }
                    }
                }

            }
            int sum = 0;
            for(int i=0;i<numbers.Count;i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}