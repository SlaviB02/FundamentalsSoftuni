using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp63
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            while(true)
            {
                string input = Console.ReadLine();
                if(input=="Craft!")
                {
                    Console.WriteLine(string.Join(", ", items));
                    break;
                }
                string[] command = input.Split(" - ");
                if(command[0]=="Collect")
                {
                    if(items.Contains(command[1])==false)
                    {
                        items.Add(command[1]);
                    }
                }
                if(command[0]=="Drop")
                {
                    if(items.Contains(command[1])==true)
                    {
                        items.Remove(command[1]);
                    }
                }
                if(command[0]=="Combine Items")
                {
                    string[] item = command[1].Split(":");
                    if(items.Contains(item[0])==true)
                    {
                        for(int i=0;i<items.Count;i++)
                        {
                            if(item[0]==items[i])
                             {
                                items.Insert(i+1, item[1]);
                            }
                        }
                    }   
                }
                if(command[0]=="Renew")
                {
                    if(items.Contains(command[1])==true)
                    {
                        string temp = command[1];
                        items.Remove(command[1]);
                        items.Add(temp);
                    }
                }
            }
        }
    }
}
