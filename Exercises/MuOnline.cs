using System;
using System.Linq;

namespace ConsoleApp62
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int coins = 0;
            string[] array = Console.ReadLine().Split("|").ToArray();
            bool flag = true;
            for(int i=0;i<array.Length;i++)
            {
                string[] command = array[i].Split();
                if(command[0]=="potion")
                {
                    int heal = int.Parse(command[1]);
                    if(health+heal>100)
                    {
                        
                        Console.WriteLine($"You healed for {100-health} hp.");
                        health = 100;
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else
                    {   
                        health += heal;
                        Console.WriteLine($"You healed for {heal} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    


                }
               else if(command[0]=="chest")
                {
                    int foundCoins = int.Parse(command[1]);
                    Console.WriteLine($"You found {foundCoins} bitcoins.");
                    coins += foundCoins;
                }
               else
                {
                    int damage = int.Parse(command[1]);
                    health = health - damage;
                    if(health>0)
                    {
                        Console.WriteLine($"You slayed {command[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command[0]}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        flag = false;
                        break;
                    }
                }
            }
            if(flag==true)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {coins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
