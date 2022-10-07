using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> nums2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for(int i=0;i<Math.Min(nums1.Count,nums2.Count);i++)
            {
               if(i<nums1.Count)
                {
                    result.Add(nums1[i]);
                }
               if(i<nums2.Count)
                {
                    result.Add(nums2[i]);
                }
           
            }
            if (nums1.Count > nums2.Count)
            {
                result.AddRange(GetRemainingElements(nums1, nums2));
            }
            else
            {
                result.AddRange(GetRemainingElements(nums2, nums1));
            }
            foreach (int number in result)
            {
                Console.Write(number + " ");
            }
        }
        static List<int> GetRemainingElements(List<int> longer,List<int>shorter)
        {
            List<int> nums = new List<int>();
            for(int i=shorter.Count;i<longer.Count;i++)
            {
                nums.Add(longer[i]);
            }
            return nums;
        }
    }
}
