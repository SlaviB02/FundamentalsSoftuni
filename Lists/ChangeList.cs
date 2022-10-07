using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> List1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    Console.WriteLine(string.Join(" ", List1));
                    break;
                }
                string[] token = input.Split();
                if (token[0] == "Delete")
                {
                    List1.RemoveAll(n=> n==int.Parse(token[1]));
                }
                if(token[0]=="Insert")
                {
                    int numberToInsert = int.Parse(token[1]);
                    int indexToInsert = int.Parse(token[2]);
                    List1.Insert(indexToInsert, numberToInsert);
                    
                }

            }
        }
    }
}
