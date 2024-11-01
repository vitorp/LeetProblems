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
            k = k % nums.Length;
            int[] nums2 = (int []) nums.Clone();
            for (int i = 0; i < nums2.Length; i++)
            {
                nums[(i+k)%nums2.Length] = nums2[i];
            }
        }
    }
}
