using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    partial class Solution
    {
        // Problem FindDifference #2215
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> result = new();
            // Initializing dict with nums1
            foreach (int i in nums1)
            {
                result[i] = 1;
            }
            // Finding conflicts and adding nums2
            foreach (int i in nums2)
            {
                int current = result.GetValueOrDefault(i);
                if (current == 0) result[i] = 2;
                if (current == 1) result[i] = -1;
            }
            IList<int> list1 = [];
            IList<int> list2 = [];
            // Adding numbers with no conflict to separate lists
            foreach ((int k, int v) in result)
            {
                if (v == 1) list1.Add(k);
                if (v == 2) list2.Add(k);
            }

            return [list1, list2];
        }
        // Using built in methods
        public IList<IList<int>> FindDifferenceAlt(int[] nums1, int[] nums2)
        {
            IList<int> list1 = nums1.Except(nums2).ToList();
            IList<int> list2 = nums2.Except(nums1).ToList();
            return [list1, list2];
        }
    }
}
