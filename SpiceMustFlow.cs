using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int produce = 0;
            int workers = 26;
            int daysCounter = 0;
            int totalProduce = 0;
            while(startingYield>=100)
            {   
                daysCounter++;
                produce = startingYield - workers;
                totalProduce += produce;
                startingYield -= 10;
            }
            if (startingYield < 100 && daysCounter == 0)
            {
                Console.WriteLine(daysCounter);
                Console.WriteLine(totalProduce);
            }
            else
            {
                totalProduce -= workers;
                Console.WriteLine(daysCounter);
                Console.WriteLine(totalProduce);
            }
        }
    }
}
