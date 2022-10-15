using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp77
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine().Split("@").Select(int.Parse).ToList();
            int index = 0;
            while(true)
            {
                string input = Console.ReadLine();
                if(input=="Love!")
                {
                    Console.WriteLine($"Cupid's last position was {index}.");
                    break;
                }
                string[] command = input.Split();
                int jump = int.Parse(command[1]);
                index += jump;
                if(index>houses.Count-1)
                {
                    index = 0;
                }
               if(houses[index]>0)
                {
                    houses[index] -= 2;
                    
                }
               if (houses[index] == 0)
                {
                    Console.WriteLine($"Place {index} has Valentine's day.");
                    houses[index] = -1;
                    continue;
                }
               if (houses[index]==-1)
                {
                    Console.WriteLine($"Place {index} already had Valentine's day.");
                }
                
               
            }
            int count = 0;
            for(int i=0;i<houses.Count;i++)
            {
                if(houses[i]>0)
                {
                    count++;
                }
            }
            if(count!=0)
            {
                Console.WriteLine($"Cupid has failed {count} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}
