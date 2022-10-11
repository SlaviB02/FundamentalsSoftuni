using System;

namespace ConsoleApp67
{
    class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine());
            double hay = double.Parse(Console.ReadLine());
            double cover = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            food *= 1000;
            hay *= 1000;
            cover *= 1000;
            weight *= 1000;
            for(int i=1;i<=30;i++)
            {
                food -= 300;
                if(i%2==0)
                {
                    double givenHay = food / 20;
                    hay -= givenHay;
                }
                if(i%3==0)
                {
                    double remove = weight / 3;
                    cover -= remove;
                }
                if(food<=0 ||hay<=0 || cover<=0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }
            food /= 1000;
            hay /= 1000;
            cover /= 1000;
            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:F2}, Hay: {hay:F2}, Cover: {cover:F2}.");
        }
    }
}
