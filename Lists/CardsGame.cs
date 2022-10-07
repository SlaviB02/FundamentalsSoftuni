using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp59
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> hand1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> hand2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            while(true)
            {
                if(hand1.Count==0)
                {
                    int sum = 0;
                    for(int i=0;i<hand2.Count;i++)
                    {
                        sum += hand2[i];
                    }
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                if (hand2.Count == 0)
                {
                    int sum = 0;
                    for (int i = 0; i < hand1.Count; i++)
                    {
                        sum += hand1[i];
                    }
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
                
                if(hand1[0]>hand2[0] )
                {
                    int wonHand = hand2[0];
                    int tempHand = hand1[0];
                    hand1.Add(tempHand);
                    hand1.Add(wonHand);
                }
               else if (hand1[0] <hand2[0] )
                {
                    int wonHand = hand1[0];
                    int tempHand = hand2[0];
                    hand2.Add(tempHand);
                    hand2.Add(wonHand);
                }
                
                hand1.RemoveAt(0);
                hand2.RemoveAt(0);
                
            }
        }
    }
}