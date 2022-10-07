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
            while(true)
            {
                string input = Console.ReadLine();
                if(input=="end")
                {
                    break;
                }
                string[] token = input.Split();
                switch(token[0])
                {
                    case "Add":int numberToAdd = int.Parse(token[1]);
                        numbers.Add(numberToAdd);break;
                    case "Remove": int numberToRemove = int.Parse(token[1]);
                        numbers.Remove(numberToRemove);break;
                    case "RemoveAt": int indexToRemove = int.Parse(token[1]);
                        numbers.RemoveAt(indexToRemove);break;
                    case "Insert": int numberToInsert = int.Parse(token[1]);
                        int indexToInsert = int.Parse(token[2]);
                        numbers.Insert(indexToInsert,numberToInsert);
                        break;
                }

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
