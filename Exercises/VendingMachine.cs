using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string input;
        double sum = 0;
        while(true)
        {
            input = Console.ReadLine();
            if(input=="Start")
            {
                break;
            }
            double coin = double.Parse(input);
            if(coin==0.1 || coin==0.2 || coin==0.5 ||coin==1 || coin==2)
            {
                sum += coin;
            }
            else
            {
                Console.WriteLine($"Cannot accept {coin}");
            }
        }
        while(true)
        {
            input = Console.ReadLine();
            if (input == "End")
            {
                Console.WriteLine($"Change: {sum:F2}");
                break;
            }
           if(input=="Nuts")
            {
                if(sum>=2)
                {
                    Console.WriteLine($"Purchased {input.ToLower()}");
                    sum -= 2;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else if (input == "Water")
            {
                if (sum >= 0.7)
                {
                    Console.WriteLine($"Purchased {input.ToLower()}");
                    sum -= 0.7;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else if (input == "Crisps")
            {
                if (sum >= 1.5)
                {
                    Console.WriteLine($"Purchased {input.ToLower()}");
                    sum -= 1.5;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
           else if (input == "Soda")
            {
                if (sum >= 0.8)
                {
                    Console.WriteLine($"Purchased {input.ToLower()}");
                    sum -= 0.8;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else if (input == "Coke")
            {
                if (sum >= 1)
                {
                    Console.WriteLine($"Purchased {input.ToLower()}");
                    sum -= 1;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else
            {
                Console.WriteLine("Invalid product");
            }

        }
    }
}