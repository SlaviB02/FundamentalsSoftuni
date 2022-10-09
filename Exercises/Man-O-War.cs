using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp66
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
          int maxHealth = int.Parse(Console.ReadLine());
            while(true)
            {
                string input = Console.ReadLine();
                if(input=="Retire")
                {
                    int pirateSum = 0;
                    int warSum = 0;
                    for(int i=0;i<pirateShip.Count;i++)
                    {
                        pirateSum += pirateShip[i];
                    }
                    for(int i=0;i<warShip.Count;i++)
                    {
                        warSum += warShip[i];
                    }
                    Console.WriteLine($"Pirate ship status: {pirateSum}");
                    Console.WriteLine($"Warship status: {warSum}");

                    break;
                }
                string[] command = input.Split();
                if(command[0]=="Fire")
                {
                    int index = int.Parse(command[1]);
                    if(index>=0 && index<warShip.Count)
                    {
                        int damage = int.Parse(command[2]);
                        if(warShip[index]-damage<=0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                        else
                        {
                            warShip[index] -= damage;
                        }
                    }
                }
                if(command[0]=="Defend")
                {
                    int start = int.Parse(command[1]);
                    int end = int.Parse(command[2]);
                    if(start>=0 && start<pirateShip.Count && end>=0 && end<pirateShip.Count)
                    {
                        for(int i=start;i<=end;i++)
                        {
                            int damage = int.Parse(command[3]);
                            pirateShip[i] -= damage;
                            if(pirateShip[i]<=0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                if(command[0]=="Repair")
                {
                    int index = int.Parse(command[1]);
                    if(index>=0 &&index<pirateShip.Count)
                    {
                        int heal = int.Parse(command[2]);
                        pirateShip[index] += heal;
                        if(pirateShip[index]>maxHealth)
                        {
                            pirateShip[index] = maxHealth;
                        }
                    }
                }
                if(command[0]=="Status")
                {
                    int count = 0;
                    for(int i=0;i<pirateShip.Count;i++)
                    {
                        if(pirateShip[i]<(double)(maxHealth/5))
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{count} sections need repair.");
                }
            }
        }
    }
}
