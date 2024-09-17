using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        // Problem #1004
        public int LongestOnes(int[] nums, int k)
        {
            int maxLength = 0;
            int flips = 0;
            int j = 0;
            int i = 0;
            for (i = 0; i < nums.Length && flips < k; i++)
            {
                if (nums[i] == 0) flips++;
                maxLength = i-j+1;
            }
            

            for(; i < nums.Length; i++)
            {
                if (nums[i] == 0) {
                    while (nums[j] != 0) j++;
                    j++;
                }
                maxLength = Math.Max(maxLength, i-j+1);
            }
            return maxLength;
        }
    }
}
