using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    partial class Solution
    {
        // Problem Merge Sorted array #88
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int end = m + n - 1;
            n = n - 1;
            m = m - 1;

            // Insert in reverse
            while (m>=0 && n >=0)
            {
                if (nums1[m] >= nums2[n])
                {
                    nums1[end] = nums1[m];
                    m--;
                } else
                {
                    nums1[end] = nums2[n];
                    n--;
                }
                end--;
            }
            // Insert remaing numbers from nums2.
            // Remaining numbers from num1 already sorted.
            while(n >= 0)
            {
                nums1[end] = nums2[n];
                n--;
                end--;
            }
        }
    }
}
