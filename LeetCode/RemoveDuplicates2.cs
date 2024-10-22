using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    partial class Solution
    {
        // Problem RemoveDuplicates2 #80
        public int RemoveDuplicates2(int[] nums)
        {
            if (nums.Length < 2) return nums.Length;
            int k = 2;

            for(int i = 2; i < nums.Length; i++)
            {
                // K works as a pointer for a new array built in place
                // Since its sorted it possible to check 2 spaces behind K to guarantee there is only 2 copies at most
                if(nums[i] != nums[k - 2])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}
