using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp100
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            
            double totalSum = 0;

            
            for(int i=0;i<input.Length;i++)
            {
                double number = 0;
                string word = input[i];
                char firstLetter = word[0];
                char lastLetter = word[word.Length - 1];
                int firstIndex = (int)firstLetter % 32;
                int lastIndex = (int)lastLetter % 32;
                for (int j = 0; j <word.Length ; j++)
                {
                    char symbol = word[j];
                    if(char.IsDigit(symbol)==true)
                    {
                        number += symbol-'0';
                        number *= 10;
                    }

                }
                number /= 10;
                double tempNumber = 0;
                if(char.IsLower(firstLetter)==true)
                {
                    tempNumber = number * firstIndex;
                }
                else
                {
                    tempNumber = number / firstIndex;
                   
                }
                if(char.IsLower(lastLetter)==true)
                {
                    tempNumber += lastIndex;
                    
                }
                else
                {
                    tempNumber -= lastIndex;
                  
                }
                totalSum += tempNumber;


            }
            Console.WriteLine($"{totalSum:F2}");
        }
        
            
    }
}
