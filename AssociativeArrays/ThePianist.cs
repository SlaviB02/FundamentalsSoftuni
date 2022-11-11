using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> pianist = new Dictionary<string, List<string>>();
            for(int i=0;i<n;i++)
            {
                string[] input = Console.ReadLine().Split("|");
                string piece = input[0];
                string composer = input[1];
                string key = input[2];
                pianist.Add(piece, new List<string> { composer, key });
            }
            while(true)
            {
                string[] token = Console.ReadLine().Split("|");
                string command = token[0];
                if(command=="Stop")
                {
                    break;
                }
                if(command=="Add")
                {
                    string piece = token[1];
                    string composer = token[2];
                    string key = token[3];
                    if(pianist.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        pianist.Add(piece, new List<string> { composer, key });
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                }
                if(command=="Remove")
                {
                    string piece = token[1];
                    if(pianist.ContainsKey(piece))
                    {
                        pianist.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                if(command=="ChangeKey")
                {
                    string piece = token[1];
                    string key = token[2];
                    if(pianist.ContainsKey(piece))
                    {
                        Console.WriteLine($"Changed the key of {piece} to {key}!");
                        pianist[piece][1] = key;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }
            foreach(var piano in pianist)
            {
                Console.WriteLine($"{piano.Key} -> Composer: {piano.Value[0]}, Key: {piano.Value[1]}");
            }
        }
    }
}
