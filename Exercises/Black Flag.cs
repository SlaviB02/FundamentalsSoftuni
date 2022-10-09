using System;

namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {
            uint days = uint.Parse(Console.ReadLine());
            uint dailyPlunder = uint.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double totalPlunder = 0.0;
            for(int i=1;i<=days;i++)
            {
                totalPlunder += dailyPlunder;
                if(i%3==0)
                {
                    double bonus = dailyPlunder * 0.50;
                    totalPlunder += bonus;
                }
                if(i%5==0)
                {
                    double loss = totalPlunder * 0.30;
                    totalPlunder -= loss;
                }
            }
            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:F2} plunder gained.");
            }
            else
            {
                double percentage = (totalPlunder/expectedPlunder* 100);
                Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
            }
        }
    }
}
