using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    partial class Solution
    {
        // Problem MajorityElement #169
        public int MajorityElement(int[] nums)
        {
            Dictionary<int,int> dic = new();
            int majority = nums[0];
            dic[0] = 1;

            foreach (int x in nums)
            {
                int newCount = dic.GetValueOrDefault(x) + 1;
                dic[x] = newCount;
                if (dic[x] > dic[majority]) majority = x;
            }
            return majority;
        }
    }
}
