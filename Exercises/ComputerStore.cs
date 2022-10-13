using System;

namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            double tax = 0;
            double total = 0;
            double discount = 0;
            while(true)
            {
                string input = Console.ReadLine();
                if(input=="special")
                {
                    discount = 0.10;
                    break;
                }
               if(input == "regular")
                {
                    break;
                }
                double price = double.Parse(input);
                if(price<=0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                tax += price / 5;
                total += price;
                
            }
            if (total <= 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                double withoutTaxes = (total + tax) - discount * (total + tax);
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {total:F2}$");
                Console.WriteLine($"Taxes: {tax:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {withoutTaxes:F2}$");


            }
        }
    }
}
