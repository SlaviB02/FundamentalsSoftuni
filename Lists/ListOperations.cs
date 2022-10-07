using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] token = input.Split();
                switch (token[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(token[1]);
                        numbers.Add(numberToAdd); break;
                    case "Remove":
                        int index = int.Parse(token[1]);
                        if (index <0 || index>numbers.Count-1)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        numbers.RemoveAt(index); break;
                    case "Insert":
                        int numberToInsert = int.Parse(token[1]);
                        int indexToInsert = int.Parse(token[2]);
                        if(indexToInsert<0||indexToInsert>numbers.Count-1)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                        
                }
                if(token[0]=="Shift")
                {
                    if(token[1]=="left")
                    {
                        int count = int.Parse(token[2]);
                        for(int i=0;i<count;i++)
                        {
                            int number = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(number);
                        }
                    }
                    if(token[1]=="right")
                    {
                        int count = int.Parse(token[2]);
                        for (int i = 0; i < count; i++)
                        {
                            int number = numbers[numbers.Count-1];
                            numbers.RemoveAt(numbers.Count-1);
                            numbers.Insert(0,number);
                        }
                    }
                }

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}