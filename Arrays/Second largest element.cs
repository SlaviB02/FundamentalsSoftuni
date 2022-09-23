using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int largest = int.MinValue;
            int secondLargest = int.MinValue;
            for(int i=0;i<size;i++)
            {
                if(arr[i]>largest)
                {
                    largest = arr[i];
                }
            }
            for(int i=0;i<size;i++)
            {
                if(arr[i]>secondLargest && arr[i]!=largest)
                {
                    secondLargest = arr[i];
                }
            }
            Console.WriteLine("Second largest element: " + secondLargest);
        }
    }
}
