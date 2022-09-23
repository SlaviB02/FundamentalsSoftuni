using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for(int i=0;i<size;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            double negative = 0;
            double positive = 0;
            int negativeCounter = 0;
            int positiveCounter = 0;
            for(int i=0;i<size;i++)
            {
                if(arr[i]<0)
                {
                    negative += arr[i];
                    negativeCounter++;
                }
                if(arr[i]>0)
                {
                    positive += arr[i];
                    positiveCounter++;
                }
            }
            Console.WriteLine("Average negative number: " + negative / negativeCounter);
            Console.WriteLine("Average positive number: " + positive / positiveCounter);
        }
    }
}
