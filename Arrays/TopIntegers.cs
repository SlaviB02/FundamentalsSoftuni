using System;
using System.Linq;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int i=0;i<arr.Length;i++)
            {
                bool flag = true;
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]<=arr[j])
                    {
                        flag = false;
                    }
                }
                if(flag==true)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
