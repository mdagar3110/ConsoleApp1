using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 13;
            Solution sol = new Solution();
             sol.HashTable_Method(nums, target);
            Console.WriteLine(sol.HashTable_Method(nums, target));
        }


    }


    public class Solution
    {
        public int[] HashTable_Method(int[] nums, int target)
        {
            Hashtable ht = new Hashtable();
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                int container = target - nums[i]; 

                if (ht.Contains(container))
                {
                    return new int[] { (int)ht[i], nums[i] };
                }
                else
                    ht.Add(i,nums[i]);
            }

        return null;
        }

        public int[] TwoSum_SimpleIteration(int[] nums, int target)
        {
            for (int i = 0; i <= nums.Length - 1; i++)
            { 
                for(int j=i+1;j<=nums.Length-1;j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { nums[i], nums[j] };
                    }
                  
                       

                }
            }
            return new int[] { 0, 0 };
            //return [0, 1];
        }
    }
}
