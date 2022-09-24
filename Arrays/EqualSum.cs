using System;
using System.Linq;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(arr.Length==1)
            {
                Console.WriteLine(0);
                return;
            }
            bool flag = true;
            for (int i=0;i<arr.Length;i++)
            {
                int rightSum = 0;
                int leftSum = 0;
                for (int j=i+1;j<arr.Length;j++)
                {
                    rightSum += arr[j];
                }
                for(int g=0;g<i;g++)
                {
                    leftSum += arr[g];
                }
                if(leftSum==rightSum)
                {
                    Console.WriteLine(i);
                    flag = false;
                    break;
                }
               
            }
            if(flag==true)
            {
                Console.WriteLine("no");
            }
        }
    }
}
