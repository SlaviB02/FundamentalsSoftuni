using System;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            TopNumber(number);
        }
        static void TopNumber(int number)
        {
            for(int i=1;i<number;i++)
            {
                if(SumOfDigits(i)==true && OddDigit(i)==true)
                {
                    Console.WriteLine(i);
                }

            }
        }
        static bool SumOfDigits(int number)
        {
            int sum = 0;
            while(number>0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            if(sum%8==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool OddDigit(int number)
        {
            while(number>0)
            {
                int digit = number % 10;
                if(digit%2!=0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

    }
}
