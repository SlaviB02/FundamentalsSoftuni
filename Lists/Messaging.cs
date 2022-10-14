using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp73
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            for(int i=0;i<numbers.Count;i++)
            {
                int temp = numbers[i];
                int sum = 0;
                while(temp>0)
                {
                    int digit = temp % 10;
                    sum += digit;
                    temp /= 10;
                }
                while(sum>input.Length)
                {
                    sum -= input.Length;
                }
                char character = input[sum];
                input = input.Remove(sum, 1);
                Console.Write(character);
            }
        }
    }
}
