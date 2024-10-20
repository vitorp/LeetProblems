using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        // Problem #724
        public int PivotIndex(int[] nums)
        {
            int[] prefix = new int[nums.Length];
            int[] suffix = new int[nums.Length];

            int acc = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                prefix[i] = acc;
                acc += nums[i];
            }
            acc = 0;
            for (int i = nums.Length-1; i >= 0; i--)
            {
                suffix[i] = acc;
                acc += nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (prefix[i] == suffix[i]) return i;
            }
            return -1;
        }
    }
}
