﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int max = int.Parse(Console.ReadLine());
            while(true)
            {
                string input = Console.ReadLine();
                if(input=="end")
                {
                    Console.WriteLine(string.Join(" ", wagons));
                    break;
                }
                string[] token = input.Split();
                if(token[0]=="Add")
                {
                    wagons.Add(int.Parse(token[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (int.Parse(token[0]) + wagons[i] <= max)
                        {
                            wagons[i] += int.Parse(token[0]);
                            break;
                        }
                    }
                }

            }
        }
    }
}
