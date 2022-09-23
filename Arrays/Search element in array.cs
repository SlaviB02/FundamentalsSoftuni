using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for(int i=0;i<size;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int element = int.Parse(Console.ReadLine());
            bool flag = true;
            int pos = 0;
            for(int i=0;i<size;i++)
            {
                if(arr[i]==element)
                {
                    pos = i;
                    flag = false;
                    break;
                }
            }
            if(flag==true)
            {
                Console.WriteLine("Element not found");
            }
            else
            {
                Console.WriteLine($"{element} is found at position {pos+1}");
            }
        }
    }
}
