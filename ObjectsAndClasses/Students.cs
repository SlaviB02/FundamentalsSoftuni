using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;

namespace ConsoleApp82
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

       
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Student> students = new List<Student>();
            while (true)
            {
                string[] data = Console.ReadLine().Split();
                if(data[0]=="end")
                {
                    break;
                }
                string firstName = data[0];
                string secondName = data[1];
                int age = int.Parse(data[2]);
                string town = data[3];
                Student std = new Student();
                std.FirstName = firstName;
                std.LastName = secondName;
                std.Age = age;
                std.Town = town;
                bool exist = true;
                foreach(var currentStudent in students)
                {
                    if(currentStudent.FirstName==std.FirstName && currentStudent.LastName==std.LastName)
                    {
                     
                        currentStudent.Age = std.Age;
                        currentStudent.Town = std.Town;
                        exist = false;
                    }
                }
                if (exist == true)
                {
                    students.Add(std);
                }
            }
                
               
            
            string city = Console.ReadLine();
            foreach(Student student in students)
            {
                if(student.Town==city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }
    }
   
}
