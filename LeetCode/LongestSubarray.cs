using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        // Problem #1493
        public int LongestSubarray(int[] nums)
        {
            int i = 0, j = 0;
            int deletes = 0;
            int maxLength = 0;
            
            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    deletes++;
                    if (deletes > 1)
                    {
                        while (nums[j] !=0) j++;
                        j++;
                        deletes--;
                    }
                }
                maxLength = Math.Max(maxLength, i - j + 1 - deletes);
            }
            if (deletes == 0) return maxLength - 1;
            return maxLength;
        }
    }
}
