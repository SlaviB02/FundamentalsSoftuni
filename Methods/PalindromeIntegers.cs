using System;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string input = Console.ReadLine();
                if(input=="END")
                {
                    break;
                }
                int number = int.Parse(input);
                Console.WriteLine(IsPalindrome(number));
            }
            
        }
        static bool IsPalindrome(int number)
        {
            int temp = number;
            int reverse = 0;
            while(temp>0)
            {
                int digit = temp % 10;
                reverse =reverse*10+digit;
                temp /= 10;
            }
            if(reverse==number)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
