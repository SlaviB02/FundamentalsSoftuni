using System;

namespace ConsoleApp10
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
            for(int i=0;i<size;i++)
            {
                if(arr[i]%2==0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
