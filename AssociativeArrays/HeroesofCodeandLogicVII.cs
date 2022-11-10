using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();
            for(int i=0;i<n;i++)
            {
                string [] input = Console.ReadLine().Split();
                int HP = int.Parse(input[1]);
                int MP = int.Parse(input[2]);
                heroes.Add(input[0], new List<int> { HP, MP });
               
            }
           while(true)
            {
                string input = Console.ReadLine();
                if(input=="End")
                {
                    break;
                }
                string[] command = input.Split(" - ");
                string type = command[0];
                if(type=="CastSpell")
                {
                    string name = command[1];
                    int mp =int.Parse(command[2]);
                    string spellName = command[3];
                    if(heroes[name][1]>=mp)
                    {
                        heroes[name][1] -= mp;
                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {heroes[name][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                }
                if (type == "TakeDamage")
                {
                    string name = command[1];
                    int damage = int.Parse(command[2]);
                    string attacker = command[3];
                    if(heroes[name][0]>damage)
                    {
                        heroes[name][0] -= damage;
                        Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heroes[name][0]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                        heroes.Remove(name);
                    }
                }
                if(type=="Recharge")
                {
                    string name = command[1];
                    int mp = int.Parse(command[2]);

                    if (heroes[name][1] + mp > 200)
                    {
                        Console.WriteLine($"{name} recharged for {200 - heroes[name][1]} MP!");
                        heroes[name][1] = 200;
                    }
                    else
                    {
                        Console.WriteLine($"{name} recharged for {mp} MP!");
                        heroes[name][1] +=mp;
                    }
                }
                if(type=="Heal")
                {
                    string name = command[1];
                    int hp = int.Parse(command[2]);
                    if (heroes[name][0] + hp > 100)
                    {
                        Console.WriteLine($"{name} healed for {100-heroes[name][0]} HP!");
                        heroes[name][0] = 100;
                    }
                    else
                    {
                        Console.WriteLine($"{name} healed for {hp} HP!");
                        heroes[name][0] += hp;
                    }
                }
            }
           foreach(var hero in heroes)
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");
            }
        }
    }
}
