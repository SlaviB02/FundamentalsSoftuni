using System;
using System.Linq;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            for(int i=0;i<rotations;i++)
            {
                for(int j=0;j<arr.Length-1;j++)
                {
                    int swap = arr[j + 1];
                    arr[j+1] =arr[j];
                    arr[j] = swap;
                }
            }
            foreach(int element in arr)
            {
                Console.Write(element + " ");
            }
        }
    }
}
