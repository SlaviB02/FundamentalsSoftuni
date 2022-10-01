using System;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            long firstFactorial = Factorial(first);
            long secondFactorial = Factorial(second);
            double result = (firstFactorial*1.0 / secondFactorial);
            Console.WriteLine($"{result:F2}");
        }
      static long Factorial(int number)
        {
            
            long result = 1;
            for(int i=1;i<=number;i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
