using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp74
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> times = Console.ReadLine().Split().Select(int.Parse).ToList();
            int finish = times.Count / 2;
            double leftRacer = 0;
            double rightRacer = 0;
            for(int i=0;i<finish;i++)
            {
                leftRacer += times[i];
                if (times[i]==0)
                {
                    leftRacer =leftRacer-leftRacer * 0.20;
                }
                                
            }
            times.Reverse();
            for(int i=0;i<finish;i++)
            {
                rightRacer += times[i];
                if (times[i] == 0)
                {
                    rightRacer = rightRacer - rightRacer * 0.20;
                }
         
            }
            if(leftRacer<rightRacer)
            {
                Console.WriteLine($"The winner is left with total time: {leftRacer}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightRacer}");
            }
        }
    }
}
