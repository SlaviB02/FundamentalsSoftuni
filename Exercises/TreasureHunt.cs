using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp65
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split("|").ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Yohoho!")
                {
                    break;
                }
                string[] command = input.Split();
                if (command[0] == "Loot")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        if (items.Contains(command[i]) == false)
                        {
                            items.Insert(0, command[i]);
                        }
                    }
                }
                if (command[0] == "Drop")
                {

                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < items.Count)
                    {
                        string temp = items[index];
                        items.RemoveAt(index);
                        items.Add(temp);
                    }
                }
                if (command[0] == "Steal")
                {
                    int count = int.Parse(command[1]);
                    List<string> steal = new List<string>();

                    if (count < items.Count)
                    {
                        for (int i = items.Count - count; i < items.Count; i++)
                        {
                            steal.Add(items[i]);
                        }

                        Console.WriteLine(string.Join(", ", steal));

                        steal.Clear();

                        items.RemoveRange(items.Count - count, count);
                    }
                    else
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            steal.Add(items[i]);
                        }
                        Console.WriteLine(string.Join(", ", steal));

                        steal.Clear();

                        items.RemoveRange(0, items.Count);
                    }
                }

                
            }
            if (items.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }

            else
            {
                double sum = 0;
                for (int i = 0; i < items.Count; i++)
                {
                    string temp = items[i];
                    sum += temp.Length;

                }
                sum = sum / items.Count;
                Console.WriteLine($"Average treasure gain: {sum:F2} pirate credits.");
            }
        }
    }
}
