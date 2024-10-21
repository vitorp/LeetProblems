using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    partial class Solution
    {
        // Problem RemoveElement #27
        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            int len = nums.Length;

            for (int i = 0; i < len; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }

            }

            return k;
        }
    }
}
