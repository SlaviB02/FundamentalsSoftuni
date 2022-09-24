using System;
using System.Linq;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] arr1 = new int[number];
            int[] arr2 = new int[number];
            bool flag = false;
            for(int i=0;i<number;i++)
            {
                int[] value = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if(flag==false)
                {
                    arr1[i] = value[0];
                    arr2[i] = value[1];
                    flag = true;
                }
                else
                {
                    arr1[i] = value[1];
                    arr2[i] = value[0];
                    flag = false;
                }
                
            }
            foreach(int element in arr1)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            foreach (int element in arr2)
            {
                Console.Write(element + " ");
            }
        }
    }
}
