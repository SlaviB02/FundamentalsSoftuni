using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp76
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split("!").ToList();
            while(true)
            {
                string input = Console.ReadLine();
                if(input=="Go Shopping!")
                {
                    Console.WriteLine(string.Join(", ", shoppingList));
                    break;
                }
                string[] command = input.Split();
                if(command[0]=="Urgent")
                {
                    string item = command[1];
                    if(shoppingList.Contains(item)==false)
                    {
                        shoppingList.Insert(0, item);
                    }
                }
                if(command[0]=="Unnecessary")
                {
                    string item = command[1];
                    if (shoppingList.Contains(item) == true)
                    {
                        shoppingList.Remove(item);
                    }
                }
                if(command[0]=="Correct")
                {
                    string oldItem = command[1];
                    string newItem = command[2];
                    if(shoppingList.Contains(oldItem)==true)
                    {
                        int index = shoppingList.IndexOf(oldItem);
                        shoppingList.Insert(index, newItem);
                        shoppingList.Remove(oldItem);
                    }
                }
                if(command[0]=="Rearrange")
                {
                    string item = command[1];
                    if(shoppingList.Contains(item)==true)
                    {
                        string temp = item;
                        shoppingList.Remove(item);
                        shoppingList.Add(temp);
                    }
                }
            }
        }
    }
}
