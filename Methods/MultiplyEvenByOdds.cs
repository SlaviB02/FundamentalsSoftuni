using System;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                number = Math.Abs(number);
            }
            int even = GetSumOfEvenDigits(number);
            int odd = GetSumOfOddDigits(number);
            Console.WriteLine(GetMultipleOfEvenAndOdds(even, odd));

        }
            static int GetSumOfEvenDigits(int number)
            {
                int sum = 0;
                while(number>0)
                {
                    int digit = number % 10;
                    if(digit%2==0)
                    {
                        sum += digit;
                            }
                    number /= 10;
                }
                return sum;
            }
            static int GetSumOfOddDigits(int number)
            {
                int sum = 0;
                while (number > 0)
                {
                    int digit = number % 10;
                    if (digit % 2 != 0)
                    {
                        sum += digit;
                    }
                    number /= 10;
                }
                return sum;
            }
       static int GetMultipleOfEvenAndOdds(int even,int odd)
        {
            return even * odd;
        }
        }

   
    }

