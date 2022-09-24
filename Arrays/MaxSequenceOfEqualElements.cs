using System;
using System.Linq;
namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int longest = 0;
            int element = 0;
            for(int i=0;i<arr.Length;i++)
            {
                int counter = 1;
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]==arr[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if(counter>longest)
                {
                    longest = counter;
                    element = arr[i];
                }
            }
            for(int i=0;i<longest;i++)
            {
                Console.Write(element + " ");
            }
        }
    }
}
