using System;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
           if(number<=0)
            {
                Console.WriteLine("0");
            }
          else if(number==1)
            {
                Console.WriteLine("1");
            }
           else if(number==2)
            {
                Console.WriteLine("1 1");
            }
           else if(number==3)
            {
                Console.WriteLine("1 1 2");
            }
           else
            {
                Console.Write("1 1 2 ");
                Tribonacci(number);
            }
        }
        static void Tribonacci(uint number)
        {
            uint first = 1;
            uint second = 1;
            uint third = 2;
            uint max = number;
            for(int i=0;i<max-3;i++)
            {
                number = first + second + third;
                first = second;
                second = third;
                third = number;
                Console.Write(number + " ");
            }
        }
    }
}
