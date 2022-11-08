using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
          while(true)
            {
                string input = Console.ReadLine();
                if(input=="Generate")
                {
                    break;
                }
                string[] command = input.Split(">>>");
                if(command[0]=="Contains")
                {
                    string substring = command[1];
                    if(key.Contains(substring))
                    {
                        Console.WriteLine($"{key} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                if(command[0]=="Flip")
                {
                    int startIndex = int.Parse(command[2]);
                    int endIndex = int.Parse(command[3]);
                    if(command[1]=="Upper")
                    {
                        string substring = key.Substring(startIndex,endIndex-startIndex);
                        string newString = substring.ToUpper();
                        key = key.Replace(substring, newString);
                        Console.WriteLine(key);
                    }
                    else
                    {
                        string substring = key.Substring(startIndex, endIndex - startIndex);
                        string newString = substring.ToLower();
                        key = key.Replace(substring, newString);
                        Console.WriteLine(key);
                    }
                }
                if(command[0]=="Slice")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    key = key.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(key);
                }
            }
            Console.WriteLine($"Your activation key is: {key}");
           
        }
    }
}