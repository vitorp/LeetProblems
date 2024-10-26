using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    partial class Solution
    {
        // Problem Rotate #189
        public void Rotate(int[] nums, int k)
        {
            int i = 0;
            int aux = nums[nums.Length - k -1];
            for (int j = nums.Length - k; j < nums.Length; j++, i++)
            {
                (nums[i], nums[j-1]) = (nums[j], nums[i]);
            }
            nums[nums.Length-1] = aux;
        }
    }
}
