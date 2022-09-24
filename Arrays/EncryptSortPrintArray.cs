using System;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i=0;i<n;i++)
            {
                string input = Console.ReadLine();
                int sum = 0;
                for(int j=0;j<input.Length;j++)
                {
                    char element = input[j];
                    if (element == 'a' || element == 'e' || element=='i' ||element=='o' ||element=='u'
                        ||element=='A' || element=='E' ||element=='I' ||element=='O' || element=='U')
                    {
                        sum += (int)element*input.Length;
                    }
                    else
                    {
                        sum += (int)element / input.Length;
                    }
                }
                arr[i] = sum;
                
            }
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]>arr[j])
                    {
                        int swap = arr[i];
                        arr[i] = arr[j];
                        arr[j] = swap;
                    }
                }
            }
            foreach(int element in arr)
            {
                Console.WriteLine(element);
            }
        }
    }
}
