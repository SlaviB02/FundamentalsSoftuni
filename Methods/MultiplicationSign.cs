using System;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            if(MultiplicationSign(num1,num2,num3)==1)
            {
                Console.WriteLine("positive");
            }
            else if(MultiplicationSign(num1,num2,num3)==-1)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("zero");
            }
        }
        static int MultiplicationSign(double num1,double num2,double num3)
        {
            int negativeCounter = 0;
            if(num1==0 || num2==0 ||num3==0)
            {
                return 0;
            }
            if (num1 <0)
            {
                negativeCounter++;
            }
            if(num2<0)
            {
                negativeCounter++;
            }
            if(num3<0)
            {
                negativeCounter++;
            }
            if(negativeCounter%2==0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
