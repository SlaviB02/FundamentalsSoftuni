using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            while(true)
            {
                string input = Console.ReadLine();
                if(input=="End")
                {
                    Console.WriteLine(string.Join("|", targets));
                    break;
                }
                string[] command = input.Split();
                if(command[0]=="Shoot")
                {
                    int index = int.Parse(command[1]);
                    if(index>=0 && index<targets.Count)
                    {
                        targets[index] -= int.Parse(command[2]);
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                if(command[0]=="Add")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, int.Parse(command[2]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                    
                }
                if(command[0]=="Strike")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < targets.Count)
                    {
                        int radius = int.Parse(command[2]);
                       if(index-radius<0 || index+radius>targets.Count-1)
                        {
                            Console.WriteLine("Strike missed!");
                            continue;
                        }
                       for(int i=index;i<=radius+index;i++)
                        {
                            targets[i] = 0;
                        }
                        for (int i = index; i >= index-radius; i--)
                        {
                            targets[i] = 0;
                        }
                        targets.RemoveAll(n => n==0);
                    }
                }
            }
        }
    }
}
