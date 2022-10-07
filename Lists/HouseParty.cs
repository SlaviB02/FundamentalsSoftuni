using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp56
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> guests = new List<string>();
            int number = int.Parse(Console.ReadLine());
            for(int i=0;i<number;i++)
            {
                string input = Console.ReadLine();
                string[] guest = input.Split();
                if(guest[2]=="not")
                {
                    bool flag = true;
                    for(int j=0;j<guests.Count;j++)
                    {
                        if(guests[j]==guest[0])
                        {
                            guests.Remove(guest[0]);
                            flag = false;
                            break;
                        }

                    }
                    if(flag==true)
                    {
                        Console.WriteLine($"{guest[0]} is not in the list!");
                    }
                    
                }
                else
                {
                    bool flag = true;
                    for (int j = 0; j < guests.Count; j++)
                    {
                        if (guests[j] == guest[0])
                        {
                            Console.WriteLine($"{guest[0]} is already in the list!");
                            flag = false;
                            break;
                        }

                    }
                    if(flag==true)
                    {
                        guests.Add(guest[0]);
                    }
                }
            }
            foreach(string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
