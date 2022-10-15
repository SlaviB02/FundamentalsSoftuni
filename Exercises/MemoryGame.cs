using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp78
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            int numberOfMoves = 0;
            while(true)
            {
                string input = Console.ReadLine();
                if(input=="end")
                {
                    break;
                }
                string[] index = input.Split();
                int first = int.Parse(index[0]);
                int second = int.Parse(index[1]);
                numberOfMoves++;
                if(first!=second && first>=0 && second>=0 && first<numbers.Count && second<numbers.Count)
               
               
                {
                    if(numbers[first]==numbers[second])
                    {
                        string element = numbers[first];
                        Console.WriteLine($"Congrats! You have found matching elements - {numbers[first]}!");
                        numbers.Remove(element);
                        numbers.Remove(element);
                        
                        
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    
                        numbers.Insert(numbers.Count / 2, "-" + numberOfMoves + "a");
                        numbers.Insert(numbers.Count / 2, "-" + numberOfMoves + "a");
                        Console.WriteLine("Invalid input! Adding additional elements to the board");
                    
                }
                if(numbers.Count==0)
                {
                    Console.WriteLine($"You have won in {numberOfMoves} turns!");
                    break;
                }
            }
            if(numbers.Count>0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
