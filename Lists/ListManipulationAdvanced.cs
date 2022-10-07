using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp52
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool flag = false;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] token = input.Split();
                switch (token[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(token[1]);
                        numbers.Add(numberToAdd);flag = true; break;
                    case "Remove":
                        int numberToRemove = int.Parse(token[1]);
                        numbers.Remove(numberToRemove);flag = true; break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(token[1]);
                        numbers.RemoveAt(indexToRemove);flag = true; break;
                    case "Insert":
                        int numberToInsert = int.Parse(token[1]);
                        int indexToInsert = int.Parse(token[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        flag = true;
                        break;
                }

                if (token[0] == "Contains")
                {
                    int number = int.Parse(token[1]);
                    if (numbers.Contains(number) == true)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                if (token[0] == "PrintEven")
                {
                    for(int i=0;i<numbers.Count;i++)
                    {
                        if(numbers[i]%2==0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                if (token[0] == "PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 !=0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                if (token[0] == "GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine(sum);
                }
                if (token[0] == "Filter")
                {
                   if(token[1]=="<")
                    {
                        for(int i=0;i<numbers.Count;i++)
                        {
                            if(numbers[i]<int.Parse(token[2]))
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                    }
                    if (token[1] == ">")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > int.Parse(token[2]))
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                    }
                    if (token[1] == "<=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= int.Parse(token[2]))
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                    }
                    if (token[1] == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= int.Parse(token[2]))
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                    }
                    Console.WriteLine();
                }


            }
            if (flag == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
