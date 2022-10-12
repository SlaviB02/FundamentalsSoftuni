using System;
using System.Linq;

namespace ConsoleApp71
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            while(true)
            {
                string input = Console.ReadLine();
                if(input=="End")
                {
                    Console.Write($"Shot targets: {count} -> ");
                    Console.Write(string.Join(" ", targets));
                    break;
                }
                int index = int.Parse(input);
                if(index>=0 && index<targets.Length)
                {
                    if(targets[index]!=-1)
                    {
                       
                        for(int i=0;i<targets.Length;i++)
                        {
                            if(i!=index &&  targets[i]!=-1)
                            {
                                if (targets[i] <= targets[index])
                                {
                                    targets[i] += targets[index];
                                }
                                else
                                {
                                    targets[i] -= targets[index];
                                }
                               
                            }
                        }
                        targets[index] = -1;
                        count++;
                    }
                }
            }
        }
    }
}
