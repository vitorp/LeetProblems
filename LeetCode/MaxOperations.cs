using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    partial class Solution
    {
        public int MaxOperations(int[] nums, int k)
        {
            Array.Sort(nums);
            int j = nums.Length - 1;
            int i = 0;
            int operations = 0;

            while (i < j)
            {
                if (nums[i] + nums[j] == k)
                {
                    operations++;
                    i++;
                    j--;
                }

                if (nums[i] + nums[j] > k) j--;
                if (nums[i] + nums[j] < k) i++;

            }
            return operations;
        }
    }
}
