using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp96
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,List<string> > courses= new Dictionary<string, List<string>>();
            while(true)
            {
                string[] input = Console.ReadLine().Split(" : ");
                if (input[0] == "end")
                {
                    break;
                }
                string course = input[0];
                string student = input[1];
                if(!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                }
                foreach(var std in courses)
                {
                    if (std.Key==course)
                    {
                        std.Value.Add(student);
                    }
                }
            }
            foreach(var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach(var std in course.Value)
                {
                    Console.WriteLine($"-- {std}");
                }
            }
        }
    }
}
